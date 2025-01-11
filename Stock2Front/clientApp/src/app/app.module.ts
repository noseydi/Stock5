import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    // سایر کامپوننت‌ها
  ],
  imports: [
    // سایر ماژول‌ها
    ReactiveFormsModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
