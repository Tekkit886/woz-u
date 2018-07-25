import { Component, OnInit } from '@angular/core';
import { Skills } from '../models/skills';
import { Level } from '../types/level.enum';

import { SkillsService } from '../services/skills.service';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.css']
})
export class SkillsComponent implements OnInit {
  skills: Skills[];
  dataService: SkillsService;

  constructor(private skillsService: SkillsService) {
    this.skills = skillsService.skills;
   }

  ngOnInit(): void {
    this.dataService.getSkills().subscribe(skills => this.skills =skills);
  }

}
