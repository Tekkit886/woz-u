import { Component, OnInit } from '@angular/core';
import { ContactsServiceService } from "../services/contacts-service.service";
import { ContactsService } from '../services/contacts.service';

@Component({
  selector: 'app-contacts-component',
  templateUrl: './contacts-component.component.html',
  styleUrls: ['./contacts-component.component.css']
})
export class ContactsComponentComponent implements OnInit {
    contacts: Contacts[];  

  constructor(private ContactsService: ContactsService) { }

  ngOnInit() {
    this.dataService.getContacts().subscribe(contacts => this.contacts = contacts);
  }

}
