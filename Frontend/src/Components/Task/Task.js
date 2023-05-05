import React from "react";
import { Tag } from "@chakra-ui/react";

const Task = (props) => {
  {
    /* 
    Task:
    - Id
    - Name
    - Topic
    - Description
    - Status
    - Priority
    - Due Date
    - Created At
    - Assigned To
    - Tags
    - Comments
*/
  }

  return (
    <li key={props.id}>
      <div className="task-container">
        <header className="task-header">
          <h3>{props.name}</h3>
          <button>&times;</button>
        </header>
        <div>
          <div>
            <label>Topic</label>
            <p>{props.topic}</p>
          </div>

          <div>
            <label>Description</label>
            <p>{props.description}</p>
          </div>

          <div>
            <label>Status</label>
            <p>{props.status}</p>
          </div>

          <div>
            <label>Priority</label>
            <p>{props.priority}</p>
          </div>

          <div>
            <label>Due</label>
            <p>{props.dueDate}</p>
          </div>

          <div>
            <label>Created</label>
            <p>{props.createdAt}</p>
          </div>

          <div>
            <label>Assigned to</label>
            <p>{props.assignedTo}</p>
          </div>

          <div>
            <label>Tags</label>
            <ul>
              {props.tags.map((tag, index) => (
                <Tag key={index}>
                  <p>{tag}</p>
                </Tag>
              ))}
            </ul>
          </div>

          <div>
            <label>Comments</label>
            <ul>
              {props.comments.map((comment, index) => (
                <li>
                  <div></div>
                </li>
              ))}
            </ul>
          </div>
        </div>
        <footer></footer>
      </div>
    </li>
  );
};

export default Task;
