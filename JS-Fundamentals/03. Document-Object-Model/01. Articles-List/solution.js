function solve() {
    let createTitle = document.getElementById('createTitle');
    let title = createTitle.value;
    let createContent = document.getElementById('createContent');
    let content = createContent.value;

    if (title !== ' ' && title !== '' && content !== ' ' && content !== '') {
        let titleElement = document.createElement('h3');
        titleElement.textContent = title;

        let contentElement = document.createElement('p');
        contentElement.textContent = content;

        let articleElement = document.createElement('article');
        articleElement.appendChild(titleElement);
        articleElement.appendChild(contentElement);
        
        let articlesElement = document.getElementById('article-list');
        articlesElement.appendChild(articleElement);

        createTitle.value = '';
        createContent.value = '';
    }
}