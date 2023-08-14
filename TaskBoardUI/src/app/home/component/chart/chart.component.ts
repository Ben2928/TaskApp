import { Component, OnInit } from '@angular/core';
import { ChartData, ChartType } from 'chart.js';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.scss']
})
export class ChartComponent implements OnInit {

  doughnutChartLabels: string[] = [
    'Done',
    'In-Progress',
    'Todo',
  ];

  doughnutChartData: ChartData<'doughnut'> = {
    labels: this.doughnutChartLabels,
    datasets: [
      { data: [2, 5, 3] },
    ],
  };

  doughnutChartType: ChartType = 'pie';

  constructor() { }

  ngOnInit(): void {
  }
}
