package projectrider.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import projectrider.entity.Project;

public interface ProjectRepository extends JpaRepository<Project, Integer> {

}
