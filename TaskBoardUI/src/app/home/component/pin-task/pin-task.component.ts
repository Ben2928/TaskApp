import { Component, OnInit } from '@angular/core';
import { WorkTaskService } from '../../../services/work-task.service';
import { WorkTaskDTO } from '../../../model/dtos/workTaskDTO';

@Component({
  selector: 'app-pin-task',
  templateUrl: './pin-task.component.html',
  styleUrls: ['./pin-task.component.scss']
})
export class PinTaskComponent implements OnInit {
  workTasks: WorkTaskDTO[] = [];
  backendConnected : boolean = false;
  constructor(private workTaskService : WorkTaskService) { }

  ngOnInit(): void {
    this.workTaskService.getAllWorkTask().subscribe(
      (workTasks)=>{
        this.backendConnected = true;
        this.workTasks = workTasks;
      })
  }
}
