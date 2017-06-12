String.prototype.toJadenCase = function () {
    let splitted = this.split(" ");
    for (let i = 0; i < splitted.length; i++) {
        let thisString = splitted[i];
        splitted[i] = splitted[i][0].toUpperCase() + splitted[i].slice(1);
    }
    return splitted.join(" ");
};