window.addEventListener("load", solve);

function solve() {
    let firstName = document.getElementById('first-name')
    let lastName = document.getElementById('last-name')
    let age = document.getElementById('age')
    let storyTitle = document.getElementById('story-title')
    let genre = document.getElementById('genre')
    let story = document.getElementById('story')

    let publishButton = document.getElementById('form-btn');
    let previewList = document.getElementById('preview-list')

    publishButton.addEventListener('click', function (){
        let firstNameValue = firstName.value;
        let lastNameValue = lastName.value;
        let ageValue = age.value;
        let storyTitleValue = storyTitle.value;
        let genreValue = genre.value;
        let storyValue = story.value;

        if (!firstNameValue || !lastNameValue || !ageValue || !storyValue || !storyTitleValue){
            return;
        }

        let newLi = document.createElement('li');
        newLi.classList.add('story-info')

        let newArticle = document.createElement('article')

        let h4 = document.createElement('h4');
        h4.textContent = `Name: ${firstNameValue} ${lastNameValue}`
        let pAge = document.createElement('p');
        pAge.textContent = `Age: ${ageValue}`;
        let pTitle = document.createElement('p');
        pTitle.textContent = `Title: ${storyTitleValue}`;
        let pGenre = document.createElement('p');
        pGenre.textContent = `Genre: ${genreValue}`;
        let pStory = document.createElement('p');
        pStory.textContent = `"${storyValue}"`;

        let saveBtn = document.createElement('button')
        saveBtn.classList.add('save-btn')
        saveBtn.textContent = 'Save Story'

        let editBtn = document.createElement('button')
        editBtn.classList.add('edit-btn')
        editBtn.textContent = 'Edit Story'

        let deleteBtn = document.createElement('button')
        deleteBtn.classList.add('delete-btn')
        deleteBtn.textContent = 'Delete Story'

        newArticle.appendChild(h4)
        newArticle.appendChild(pAge)
        newArticle.appendChild(pTitle)
        newArticle.appendChild(pGenre)
        newArticle.appendChild(pStory)
    }
}
