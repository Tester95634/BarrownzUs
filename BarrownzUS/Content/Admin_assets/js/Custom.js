//This js Add blog page start here=============================

//CkEditor
CKEDITOR.replace('BlogDescription');


//validation
function validateForm() {
    let isValid = true;

    // Clear all previous error messages
    document.querySelectorAll('.text-danger').forEach(el => el.textContent = '');

    // Blog Image
    const blogImg = document.getElementById('Blog_Img');
    if (!blogImg.files || blogImg.files.length === 0) {
        document.getElementById('error_Blog_Img').textContent = 'Please upload a blog image.';
        isValid = false;
    }

    // Category
    const category = document.getElementById('CategoryID');
    if (category.value.trim() === '') {
        document.getElementById('error_CategoryId').textContent = 'Please select a category.';
        isValid = false;
    }

    // Meta Title
    const metaTitle = document.getElementById('MetaTitle');
    if (metaTitle.value.trim() === '') {
        document.getElementById('error_MetaTitle').textContent = 'Meta title is required.';
        isValid = false;
    }

    // Meta Description
    const metaDescription = document.getElementById('MetaDescription');
    if (metaDescription.value.trim() === '') {
        document.getElementById('error_MetaDescription').textContent = 'Meta description is required.';
        isValid = false;
    }

    // Slug
    const slug = document.getElementById('Slug');
    if (slug.value.trim() === '') {
        document.getElementById('error_Slug').textContent = 'Slug is required.';
        isValid = false;
    }

    // Blog Title
    const blogTitle = document.getElementById('BlogTitle');
    if (blogTitle.value.trim() === '') {
        document.getElementById('error_BlogTitle').textContent = 'Blog title is required.';
        isValid = false;
    }

    return isValid;
}
//This js Add blog page end here=============================


//This js Blog list start here=============================

// JavaScript to truncate BlogDescription to 10 words
document.querySelectorAll('.blog-description').forEach(function (element) {
    const fullText = element.getAttribute('data-full');
    const truncatedText = truncateText(fullText, 10);
    element.textContent = truncatedText;
});

function truncateText(text, wordLimit) {
    const words = text.split(' ');
    if (words.length > wordLimit) {
        return words.slice(0, wordLimit).join(' ') + '...';
    }
    return text;
}

//This js Blog list end here=============================
