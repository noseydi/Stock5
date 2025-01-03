import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductFormComponent } from './product-form/product-form.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    // سایر کامپوننت‌ها
    ProductFormComponent
  ],
  imports: [
    // سایر ماژول‌ها
    ReactiveFormsModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
