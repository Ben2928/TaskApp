import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { WorkTaskDTO } from '../model/dtos/workTaskDTO';

@Injectable({
  providedIn: 'root'
})
export class WorkTaskService {
  readonly baseUrl = environment.baseApiUrl;

  constructor(private http : HttpClient) { }

  getAllWorkTask(): Observable<WorkTaskDTO[]>{
    return this.http.get<WorkTaskDTO[]>(`${this.baseUrl}api/Task/getWorkTasks` );
  }
}
