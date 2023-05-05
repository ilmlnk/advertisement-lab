import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Task from './Task';

const TasksList = () => {

  const [tasks, setTasks] = useState([]);

  useEffect(() => {
    axios.get('https://localhost:50555/api/TaskController/tasks')
    .then(response => setTasks(response.data))
    .catch(error => console.error(error));
  }, []);

  return (
    <div>
      <ul>
        {tasks.map(task => (
            <Task 
            key={task.id}
            name={task.name}
            topic={task.topic}
            status={task.status}
            description={task.description}
            priority={task.priority}
            dueDate={task.dueDate}
            createdAt={task.createdAt}
            assignedTo={task.assignedTo}
            tags={task.tags}
            comments={task.comments}
            />
        ))}
      </ul>
    </div>
  );
}

export default TasksList;
