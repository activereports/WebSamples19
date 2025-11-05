import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

import { NavMenuComponent } from './nav-menu/nav-menu.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  imports: [NavMenuComponent, RouterOutlet]
})
export class AppComponent {
  title = 'app';
}
