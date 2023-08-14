import { TaskStatusEnum } from "../enums/taskStatusEnum";

export interface WorkTaskDTO {
  title: string;
  description: string;
  createdDate: Date;
  updatedDate: Date;
  status: TaskStatusEnum;
}
