<?php

namespace app\controllers;

use Yii;
use yii\filters\AccessControl;
use yii\filters\VerbFilter;

use yii\web\Controller;
use yii\web\Response;

use yii\helpers\Html;

use yii\data\ActiveDataProvider;

use app\models\LoginForm;
use app\models\ContactForm;
use app\models\ActionForm;
use app\models\BasesForm;
use app\models\ChemicalsForm;
use app\models\FieldsForm;
use app\models\Fields_doneForm;
use app\models\FuelForm;
use app\models\Fuel_on_baseForm;
use app\models\TechnicsForm;
use app\models\TypeForm;
use app\models\UsersForm;
use app\models\WorkersForm;


use app\models\Action;
use app\models\Bases;
use app\models\Chemicals;
use app\models\Fields;
use app\models\Fields_done;
use app\models\Fuel;
use app\models\Fuel_on_base;
use app\models\Technics;
use app\models\Type;
use app\models\Users;
use app\models\Workers;



class TableController extends Controller
{
    public function actions()
    {
        return [
            'error' => [
                'class' => 'yii\web\ErrorAction',
            ],
            'captcha' => [
                'class' => 'yii\captcha\CaptchaAction',
                'fixedVerifyCode' => YII_ENV_TEST ? 'testme' : null,
            ],
        ];
    }

////////////////////////////////////////////////////////////////
//Users

    public function actionUsers()
    {
        return $this->render('users');
    }
    

    /////////////////////////////////////////////////////
    //Bases
    public function actionUpdatebases($id)
    {
        $model = Bases::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['bases','id'=>$id]);
        }
        return $this->render('basesedit', ['model' => $model]);
    }
    public function actionDeletebases($id)
    {
        $model = Bases::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['bases']);
    }
    public function actionBases()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Bases::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new BasesForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('bases', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('bases', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
       
    }

    ///////////////////////////////////////////////////
    //Chemicals

    public function actionUpdatechemicals($id)
    {
        $model = Chemicals::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['chemicals','id'=>$id]);
        }
        return $this->render('chemicalsedit', ['model' => $model]);
    }
    public function actionDeletechemicals($id)
    {
        $model = Chemicals::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['chemicals']);
    }
    public function actionChemicals()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Chemicals::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new ChemicalsForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('chemicals', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('chemicals', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    ///////////////////////////////////////////////////
    //Fields

    public function actionUpdatefields($id)
    {
        $model = Fields::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['fields','id'=>$id]);
        }
        return $this->render('fieldsedit', ['model' => $model]);
    }
    public function actionDeletefields($id)
    {
        $model = Fields::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['fields']);
    }
    public function actionFields()
    {
                if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Fields::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new FieldsForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('fields', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('fields', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    /////////////////////////////////////////////////////////////////////
    //Fields_done

    public function actionUpdatefields_done($id)
    {
        $model1 = Fields_done::findOne($id);
        if($model1->load(Yii::$app->request->post())){
            $model1->save();
            return $this->redirect(['fields_done','id'=>$id]);
        }
        return $this->render('fields_doneedit', ['model1' => $model1]);
    }
    public function actionDeletefields_done($id)
    {
        $model = Fields_done::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['fields_done']);
    }
    public function actionFields_done()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Fields_done::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model1 = new Fields_doneForm();
        $model1->date = date("Y-m-d H:i:s");
        if ($model1->load(Yii::$app->request->post())) {

        if($model1->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('fields_done', ['model1' => $model1, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('fields_done', ['model1' => $model1, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    //Technics

    public function actionUpdatetechnics($id)
    {
        $model = Technics::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['technics','id'=>$id]);
        }
        return $this->render('technicsedit', ['model' => $model]);
    }
    public function actionDeletetechnics($id)
    {
        $model = Technics::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['technics']);
    }
    public function actionTechnics()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Technics::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new TechnicsForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('technics', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('technics', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }
    
    /////////////////////////////////////////////////////////////////////////////////////////
    //Action

    public function actionUpdateaction($id)
    {
        $model = Action::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['action','id'=>$id]);
        }
        return $this->render('actionedit', ['model' => $model]);
    }
    public function actionDeleteaction($id)
    {
        $model = Action::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['action']);
    }
    public function actionAction()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Action::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new ActionForm();
        $model->time = date("Y-m-d H:i:s");
        $model->user = Yii::$app->user->identity->surname;
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('action', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('action', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
       return $this->redirect(['/site/login']);
    }

    }
    
    ///////////////////////////////////////////////////////////////////////////////////////
    //Fuel

    public function actionUpdatefuel($id)
    {
        $model = Fuel::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['fuel','id'=>$id]);
        }
        return $this->render('fueledit', ['model' => $model]);
    }
    public function actionDeletefuel($id)
    {
        $model = Fuel::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['fuel']);
    }
    public function actionFuel()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Fuel::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new FuelForm();
        $model->time = date("Y-m-d H:i:s");
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('fuel', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('fuel', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    ///////////////////////////////////////////////////////////////////////////////////////
    //Fuel_on_base

    public function actionUpdatefuel_on_base($id)
    {
        $model = Fuel_on_base::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['fuel_on_base','id'=>$id]);
        }
        return $this->render('fuel_on_baseedit', ['model' => $model]);
    }
    public function actionDeletefuel_on_base($id)
    {
        $model = Fuel_on_base::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['fuel_on_base']);
    }
    public function actionFuel_on_base()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Fuel_on_base::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new Fuel_on_baseForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('fuel_on_base', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('fuel_on_base', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    ///////////////////////////////////////////////////////////////////////////////////////
    //Workers

    public function actionUpdateworkers($id)
    {
        $model = Workers::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['workers','id'=>$id]);
        }
        return $this->render('workersedit', ['model' => $model]);
    }
    public function actionDeleteworkers($id)
    {
        $model = Workers::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['workers']);
    }
    public function actionWorkers()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Workers::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new WorkersForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('workers', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('workers', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }

    ///////////////////////////////////////////////////////////////////////////////////////
    //Type
    public function actionUpdatetype($id)
    {
        $model = Type::findOne($id);
        if($model->load(Yii::$app->request->post())){
            $model->save();
            return $this->redirect(['type','id'=>$id]);
        }
        return $this->render('typeedit', ['model' => $model]);
    }
    public function actionDeletetype($id)
    {
        $model = Type::findOne($id);
        if($model)
            $model->delete();
        
        return $this->redirect(['type']);
    }
    public function actionType()
    {
        if(!Yii::$app->user->isGuest){  
       $dataProvider = new ActiveDataProvider([
    'query' => Type::find(),
    'pagination' => [
        'pageSize' => 20,
    ],
    ]); 
        $model = new TypeForm();
        if ($model->load(Yii::$app->request->post())) {

        if($model->save())
        {
            Yii::$app->session->setFlash('success', 'This is the message');
            return $this->refresh();
        }
        else{
            Yii::$app->session->setFlash('error', 'This is the error');
        }
        return $this->render('type', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    else{
        return $this->render('type', ['model' => $model, 'dataProvider' => $dataProvider]);
    }
    }
    else 
    {
        return $this->redirect(['/site/login']);
    }
    }
}
?>