const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Task = sequelize.define('Task', {
        title: Sequelize.STRING,
        status: Sequelize.STRING
    });

    return Task;
};