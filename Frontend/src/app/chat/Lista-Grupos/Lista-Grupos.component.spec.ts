/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ListaGruposComponent } from './Lista-Grupos.component';

describe('ListaGruposComponent', () => {
  let component: ListaGruposComponent;
  let fixture: ComponentFixture<ListaGruposComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListaGruposComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaGruposComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
