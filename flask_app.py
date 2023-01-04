from flask import Flask, redirect, render_template, request, url_for

from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

# Database settings

SQLALCHEMY_DATABASE_URI = "mysql+mysqlconnector://{username}:{password}@{hostname}/{databasename}".format(
    username="germio",
    password="Germaine1234",
    hostname="germio.mysql.pythonanywhere-services.com",
    databasename="germio$default",
)
app.config["SQLALCHEMY_DATABASE_URI"] = SQLALCHEMY_DATABASE_URI
app.config["SQLALCHEMY_POOL_RECYCLE"] = 299
app.config["SQLALCHEMY_TRACK_MODIFICATIONS"] = False

db = SQLAlchemy(app)


# Table models

class Pledge(db.Model):

    __tablename__ = "tblPledge"

    id = db.Column(db.Integer, primary_key=True)
    pledge = db.Column(db.String(4096), nullable=False)
    country = db.Column(db.String(100), nullable=False)
    screen_name = db.Column(db.String(100), nullable=False)


# Application routes

@app.route("/")
def index():
    return render_template("index.html")

@app.route("/pledges", methods=["GET", "POST"])
def pledges():
    if request.method == "GET":
        data = Pledge.query.all()
        return render_template("pledges.html", pledge_data=data)
    else:
        record = Pledge(pledge=request.form["pledge"], country=request.form["country"], screen_name=request.form["screen_name"])
        db.session.add(record)
        db.session.commit()
        return redirect(url_for("pledges"))


