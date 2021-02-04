const Task = require('../models').Task;

module.exports = {
    index: (req, res) => {
        Task
            .findAll()
            .then(tasks => {
                let openTasks = tasks.filter(t => t.status === 'Open');
                let inProgressTasks = tasks.filter(t => t.status === 'In Progress');
                let finishedTasks = tasks.filter(t => t.status === 'Finished');

                res.render('task/index', {
                    'openTasks': openTasks,
                    'inProgressTasks': inProgressTasks,
                    'finishedTasks': finishedTasks
                });
            })
    },
    createGet: (req, res) => {
        res.render('task/create');
    },
    createPost: (req, res) => {
        let args = req.body;
        Task
            .create(args)
            .then(() => res.redirect('/'));
    },
    editGet: (req, res) => {
        let id = req.params.id;

        Task
            .findById(id)
            .then(task => res.render('task/edit', task.dataValues));
    },
    editPost: (req, res) => {
        let id = req.params.id;
        let args = req.body;

        Task
            .findById(id)
            .then(task => task.updateAttributes(args).then(() => res.redirect('/')));
    }
};