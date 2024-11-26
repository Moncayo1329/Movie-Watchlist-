*{

  padding: 0;
  margin: 0;
}


body {
  background-color: rgb(219, 219, 219);
  padding: 0;
  margin: 0;
}

p {
  margin-bottom: 1.5rem;
  max-width: 40em;
}

h1,
h2,
h3,
h4,
h5 {
  margin-bottom: 4.3rem;
  font-weight: 500;
  color: rgba(14, 13, 13, 0.247);
}



h4 {
  font-size: 1.563rem;
}


a {
  text-decoration: none;
}
/*
     Buttons 
*/

.button{
  cursor: pointer;
  border: none;
  border-radius: 10px;
  padding: 15px 30px;
  box-shadow: 15px ;
  transition: var(--transition);
  background-color: rgb(92, 89, 86);
  color: #f7f2f2fb;
}



/*
     FORM 
*/
form {
  width: 50rem;
  border-radius: 20px;
  padding: 0.1rem 0.1rem ;
}

input {

  width: 20rem;
  padding: 1rem 1rem;
  border-radius: 100px;
  border: 1px solid var(--grey-300);
  background-color: rgb(218, 217, 216);
  color: rgb(12, 12, 12);
  
}


::placeholder {
  color:rgb(8, 8, 8);
  padding: 0.5rem 0.5rem;
}


.task-form,
.single-task-form {
  width: 15vw;
  margin: 0 auto;
  margin-top:10px;
}

@media screen and (min-width: 576px) {
  .form-control {
    display: flex;
  }
  .task-input {
    border-radius: 0;
    border-top-left-radius: var(--borderRadius);
    border-bottom-left-radius: var(--borderRadius);
  }
  .submit-btn {
    margin-top: 0;
    width: 175px;
    border-radius: 0;
    border-top-right-radius: var(--borderRadius);
    border-bottom-right-radius: var(--borderRadius);
  }
}
form > :first-child {
  margin-top: 0;
}
form > :last-child {
  margin-bottom: 0;
}
/* Basic Classes */
.alert {
  padding: 0.375rem 0.75rem;
  margin-bottom: 1rem;
  border-color: transparent;
  border-radius: var(--borderRadius);
}

.alert-success {
  color: var(--green-dark);
  background-color: var(--green-light);
}
.alert-danger {
  color: var(--red-dark);
  background-color: var(--red-light);
}
.text-danger {
  color: var(--red-dark);
}
.text-success {
  color: var(--green-dark);
}
/* loading */
@keyframes spinner {
  to {
    transform: rotate(360deg);
  }
}

.loading {
  width: 6rem;
  height: 6rem;
  border-radius: 50%;
  border: 3px solid #ccc;
  border-top-color: var(--clr-primary-5);
  animation: spinner 0.6s linear infinite;
}
.loading {
  margin: 0 auto;
}
/* form loading */

.form-loading {
  position: relative;
}
.form-loading::before {
  background: var(--white);
  position: absolute;
  content: '';
  height: 100%;
  width: 100%;
  top: 0;
  left: 0;
  border-radius: var(--borderRadius);
  opacity: 0.8;
}

.form-loading::after {
  content: '';
  position: absolute;
  top: calc(50% - 3rem);
  left: calc(50% - 3rem);
  width: 6rem;
  height: 6rem;
  border-radius: 50%;
  border: 3px solid #ccc;
  border-top-color: var(--clr-primary-5);
  animation: spinner 0.6s linear infinite;
}

/*************
     TASKS
*************/

/* Task Links */
.empty-list {
  text-align: center;
}
.tasks-container {
  width: 50%;
  width: 50vw;
  max-width: var(--fixed-width);
  margin: 0 auto;
  margin-top: 2rem;
  padding-bottom: 6rem;
}

.tasks {
  display: grid;
  gap: 1rem;
}
.single-task {
  padding: 1rem 2.5rem;
  background: var(--white);
  border-radius: var(--borderRadius);
  box-shadow: var(--shadow-2);
  transition: var(--transition);
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.single-task:hover {
  box-shadow: var(--shadow-4);
}
.single-task h5 {
  margin-bottom: 0;
}
.single-task span {
  display: inline-block;
  width: 0.5rem;
  height: 0.5rem;
  margin-left: -1.25rem;
  margin-right: 1.5rem;
}
.single-task .fa-check-circle {
  font-size: 1rem;
  color: var(--green-dark);
  visibility: hidden;
}
.task-completed h5 {
  text-decoration: line-through;
}
.task-completed .fa-check-circle {
  visibility: visible;
}
.loading-text {
  visibility: hidden;
}




.movie-card {
  border: 1px solid #ddd;
  border-radius: 10px;
  padding: 16px;
  margin: 16px;
  text-align: center;
  width: 300px;
  background-color: #f9f9f9;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.movie-poster {
  width: 85%;
  height: auto;
  border-radius: 8px;
}

.movie-title {
  font-size: 1em;
  margin: 9px 0;
  color: #333;
}

.movie-description {
  font-size: 0.9em;
  color: #555;
}