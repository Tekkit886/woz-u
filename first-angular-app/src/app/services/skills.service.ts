import { Injectable } from '@angular/core';

import { Skills } from '../models/skills';
import { Level } from '../types/level.enum';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SkillsService {
  skills: Skills [] = [
    {
      id: 0,
      name: 'Ruby on rails',
      level: Level.Intermediate
    },
    { 
      id: 1,
      name: 'HTML',
      level: Level.Advanced
    },
    { 
      id: 2,
      name: 'CSS',
      level: Level.Advanced 
    },
    {
      id: 3,
      name: 'Prototyping',
      level: Level.Advanced
    }
  ];
  getSkills = (): Observable<Skills[]> => {
    return of(this.skills);
   };
}
