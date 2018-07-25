import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { SkillsComponent } from './skills/skills.component';

import { SkillsService } from './services/skills.service';
import { ContactsComponent } from './contacts/contacts.component';
import { GreetingComponent } from './greeting/greeting.component';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { ClickMeComponent } from './click-me/click-me.component';

@NgModule({
  declarations: [
    AppComponent,
    SkillsComponent,
    ContactsComponent,
    GreetingComponent,
    ContactFormComponent,
    ClickMeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [SkillsService],
  bootstrap: [AppComponent]
})

export class AppModule { }
