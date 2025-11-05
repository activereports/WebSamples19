import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { ReportViewerComponent } from './report-viewer/report-viewer.component';
import { ViewComponent } from './view/view.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'view/:id', component: ViewComponent }
];

@NgModule(
  {
    declarations: [
    ],
    imports: [RouterModule.forRoot(routes), HomeComponent, ReportViewerComponent, ViewComponent],
    exports: [RouterModule]
  })
export class AppRoutingModule { }
