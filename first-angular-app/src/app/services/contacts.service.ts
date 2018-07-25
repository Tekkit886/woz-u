import { Injectable } from '@angular/core';
import { Contact } from '../models/contact';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {
  contacts: Contact[] = [
    {
      firstName: 'Tony',
      lastName: 'Stark',
      phoneNumber: '555-555-5555',
      email: 'tony@starktech.com'
    },
    {
      firstName: 'Bruce',
      lastName: 'Banner',
      phoneNumber: '555-555-5556',
      email: 'drbruce@dontmake me angry.com'
    },
    {
      firstName: 'Phil',
      lastName: 'Coulson',
      phoneNumber: '555-555-5557',
      email: 'phil@shield.gov'
    }
  ];

  getContacts = (): Observable<Contact[]> => {
    return of(this.contacts);
  };
}
