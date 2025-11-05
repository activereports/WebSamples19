import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

//@NgModule({
//  declarations: [
//    AppComponent
//  ],
//  imports: [
//    BrowserModule, HttpClientModule,
//    AppRoutingModule
//  ],
//  providers: [],
//  bootstrap: [AppComponent]
//})
//export class AppModule { }

@NgModule({
  declarations: [
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    AppComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

