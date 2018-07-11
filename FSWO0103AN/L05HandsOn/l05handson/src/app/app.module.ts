import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ContactsComponentComponent } from './contacts-component/contacts-component.component';
import { ContactsService } from './services/contacts.service';

@NgModule({
  declarations: [
    AppComponent,
    ContactsComponentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [ContactsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
