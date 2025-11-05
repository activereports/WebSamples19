import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router'; 

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css'],
  imports: [CommonModule, RouterModule]
})
export class NavMenuComponent {
  isExpanded = false;

  public reports: string[] = new Array<string>();
  public ListTitle: string;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    if (navigator.language === 'ja') {
      this.ListTitle = 'JS Viewer  -  Angularサンプル';
    } else {
      this.ListTitle = 'JS Viewer - Angular Sample';
    }

    http.get<string[]>(baseUrl + 'reports').subscribe(result => {
      this.reports = result;
    }, error => console.error(error));
  }
}

