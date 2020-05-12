import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { HomeComponent } from './home.component';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeComponent ]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the HomeComponent', () => {
    expect(component).toBeDefined();
  });

  it('should have <h1> with "Hello world!"', () => {
    const homeComponentElement: HTMLElement = fixture.nativeElement;
    const h1 = homeComponentElement.querySelector('h1');
    expect(h1.textContent).toEqual('Hello, world!');
  });

});
