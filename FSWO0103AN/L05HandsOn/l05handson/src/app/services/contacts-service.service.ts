import { Injectable } from '@angular/core';

import { Contacts } from '../models/contacts';
import { Contacts } from '/contacts-component/contacts';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContactsServiceService {
  contacts: Contacts[] = [
    {
      firstName: 'Brue',
      lastName:  'Banner',
      phoneNumber: '555-1234',
      email: 'burce@youwouldntlikeitwhenIamangry.com',
    },
    {
      firstName: 'Tony',
      lastName: 'Stark',
      phoneNumber: '555-1235',
      email: 'thebest@starkind.org',
    },
    {
      firstName: 'Thor',
      lastName: 'Oden',
      phoneNumber: '555-1236',
      email: 'sonofoden@pointbreak.com',
    },
  ];

  getContacts = (): Observable<Contacts[]> => {
    return of(this.contacts);
  };

  constructor() { }
}
