import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { ReportViewerComponent } from '../report-viewer/report-viewer.component';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css'],
  imports: [ReportViewerComponent]
})
export class ViewComponent implements OnInit, OnDestroy {
  public reportName: string = "";
  private sub: any;

  constructor(private route: ActivatedRoute) {
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.reportName = params['id'];
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
