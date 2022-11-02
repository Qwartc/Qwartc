<?php

/* @var $this yii\web\View */
use yii\helpers\Html;

use yii\widgets\LinkPager;
use yii\widgets\ActiveForm;
use yii\widgets\Pjax;

use yii\bootstrap\Modal;

use app\models\Action;
use app\models\ActionForm;
use app\models\Type;
use app\models\Bases;

use yii\grid\GridView;



$this->title = 'События';
$users = Action::find()->orderBy('id')->all();
$types = Type::find()->orderBy('id')->all();
$bases = Bases::find()->orderBy('id')->all();
?>

<?php
    if(!Yii::$app->user->isGuest){

     Modal::begin([
        'header' => '<h2>Событие</h2>',
        'toggleButton' => [
            'label' => 'Добавить событие',
            'tag' => 'button',
            'class' => 'btn btn-success site-index',
        ]
    ]);
?>
    <?php
     $action = ActiveForm::begin(['id' => 'contact-form']); ?>

     <?= $action->field($model, 'type')->dropdownList(
    Type::find()->select(['name', 'id'])->indexBy('name')->column())->label('Тип события');?>

     <?= $action->field($model, 'base')->dropdownList(
    Bases::find()->select(['name', 'id'])->indexBy('name')->column())->label('База');?>

    <?= $action->field($model, 'amount')->textInput(['autofocus' => true])->label('Количество'); ?>

    <?= $action->field($model, 'comment')->textarea(['rows' => 6])->label('Коментарий'); ?>

    <?= $action->field($model, 'time')->textInput()->label('Время')->hint(date("Y-m-d H:i:s"));?>
    <?= $action->field($model, 'user')->textInput()->label('Учасник')->hint(Yii::$app->user->identity->surname); ?>
 
    
 
    <div class="form-group">
        <?= Html::submitButton('Записать', ['class' => 'btn btn-primary', 'name' => 'contact-button']) ?>
    </div>
    <?php ActiveForm::end(); ?>
 
<?php Modal::end();}

 ?>
<div class="site-index">
<h1>События</h1>
<?php     
echo GridView::widget([
    'dataProvider' => $dataProvider,
    'columns' => [
        ['attribute' => 'time','label' => 'Время', 'format' => ['date', 'php:Y-m-d H:i:s']],
        ['attribute'=>'type', 'label' =>'Тип работ'],
        ['attribute'=>'amount', 'label' => 'Количество'],
        ['attribute'=>'base', 'label' => 'База'],
        ['attribute'=>'comment', 'label' => 'Коментарий'],
        ['attribute'=>'user', 'label' =>'Учасник'],
        ['class' => 'yii\grid\ActionColumn', 'template' => '{update} {delete}','urlCreator' => function ($action, $model, $key, $index) {
    if ($action === 'update') {
        return '/index.php?r=table%2Fupdateaction&id=' . $model->id;
    }
    elseif($action === 'delete'){
        return '/index.php?r=table%2Fdeleteaction&id=' . $model->id;
    }
}  /*'actionupdate'*/]
    ]   
]);
?>
</div>
