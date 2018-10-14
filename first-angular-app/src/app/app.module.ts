import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { SkillsModule } from './modules/skills/skills.module';

import { AppComponent } from './app.component';

import { SkillsService } from './services/skills.service';

import { GreetingComponent } from './greeting/greeting.component';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { ClickMeComponent } from './click-me/click-me.component';
import { ContactsModule } from './modules/contacts/contacts.module';
import { AppRoutingModule } from './/app-routing.module';
import { SkillsComponent } from './skills/skills.component';
import { MoviesModule } from './modules/movies/movies.module';
import { MusicModule } from './modules/music/music.module';

@NgModule({
  declarations: [
    AppComponent,
    SkillsComponent,
    GreetingComponent,
    ContactFormComponent,
    ClickMeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ContactsModule,
    SkillsModule,
    AppRoutingModule,
    MoviesModule,
    MusicModule
  ],
  providers: [SkillsService],
  bootstrap: [AppComponent]
})

export class AppModule { }
