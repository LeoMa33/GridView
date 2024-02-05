# GridView | Xamarin

## 📌 Sommaire
1. [Description du Projet](#📋-description)
2. [Fonctionalités](#🌟-fonctionalités)
3. [Utilisation](#💻-utilisation)
    * [Créer un template de View](#créer-un-template-de-view)
    * [Créer un item](#créer-un-item)
    * [Créer la GridView](#créer-la-gridview)
4. [Documentation](#📑-documentation)
    * [GridView](#gridview)
    * [GridViewItem](#gridviewitem)
## 🎯 Badges

[![License MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Xamarin Framework](https://img.shields.io/badge/Framework-Xamarin-blue.svg)](https://visualstudio.microsoft.com/fr/xamarin/)
[![Langage C#](https://img.shields.io/badge/Langage-CSharp-blue.svg)](https://learn.microsoft.com/fr-fr/dotnet/csharp/)

## 📋 Description

Ce projet a pour but de partager une solution de GridView pouvant afficher différents modèles de View sous la forme d'une grille.

## 🌟 Fonctionalités

- Créer des Views personnalisées.

- Fournir une liste de "View" à organiser en grille.

- La capacité de définir le nombre maximum de lignes ou de colonnes dans la grille.

## 💻 Utilisation

### Créer un template de View :

[ExempleItemView.xaml](./GridView/Exemple/ExempleItemView.xaml)
```xml
<ViewCell
    x:Class="GridView.ExempleItemView"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
    <ViewCell.View>
        <StackLayout>
            <Label x:Name="Name" />
            <Label x:Name="Topic" />
        </StackLayout>
    </ViewCell.View>
</ViewCell>
```

[ExempleItemView.xaml.cs](./GridView/Exemple/ExempleItemView.xaml.cs)
```c#
public partial class ExempleItemView : ViewCell
{
    public ExempleItemView(ExempleItem item)
    {
        InitializeComponent();

        Name.Text = item.name;
        Topic.Text = item.topic;
    }
}

```

### Créer un item :

Cette classe contiendra les propriétés des items que l'on souhaite afficher.
Elle hérite de la classe [```GridViewItem```](#gridviewitem) qui contiens les méthodes nécessaires pour l'affichage des Views dans la GridView.

```c#
public class ExempleItem : GridViewItem
{
    public string name { get; set; }
    
    public string topic { get; set; }

    public ExempleItem(string name, string topic)
    {
        this.name = name;
        this.topic = topic;
        
        this.SetView(new ExempleItemView(this).View);
    }
}
```

### Créer la GridView :

Après avoir créé les différents templates que vous souhaitez afficher :
- Instanciez une nouvelle [```GridView```](#gridview) en lui précisant le nombre de lignes 
maximum ou bien le nombre de colonnes maximum.
```c#
GridView gridView = new GridView(maxRow:2);
```
- Instanciez vos items.
```c#
ExempleItem exI1 = new ExempleItem("Titre 1", "Topic 1");
ExempleItem exI2 = new ExempleItem("Titre 2", "Topic 2");
ExempleItem exI3 = new ExempleItem("Titre 3", "Topic 3");
ExempleItem exI4 = new ExempleItem("Titre 4", "Topic 4");
ExempleItem exI5 = new ExempleItem("Titre 5", "Topic 5");
```
- Assignez vos items à votre [```GridView```](#gridview).
```c#
gridView.ListItems = new List<GridViewItem>()
{
    exI1, exI2, exI3, exI4, exI5
};
```
- Ajoutez la GridView à votre page.
```c#
Container.Children.Add(gridView);
```

Votre GridView devrez maintenant s'afficher sur votre page.

[Exemple](./GridView/MainPage.xaml.cs)


## 📑 Documentation

### GridView
----
Cette classe contient toutes les propriétés permettant la gestion de l'affichage de la grille.

<br>

| Propriété  | Setter | Utilisation |
| :--------------- | :--- | -----:|
| **ListItems** | ***List\<GridViewItem>*** | Contient la liste des items à afficher. |
| **MaxRow** | ***int*** | Renvoie le template de View associé à l'item. |
| **MaxColumn** | ***int*** | Renvoie le template de View associé à l'item. |

<br>

### GridViewItem
----
Cette classe contient toutes les méthodes nécessaire à l'affichage et à la gestion des idées à afficher.
Elle doit être appelée en tant que classe mère de chacune des classes des items que vous souhaitez afficher.

<br>

| Méthode  | Utilisation |
| :--------------- | -----:|
| GridViewItem.**SetView(View)** | Permet de définir le template de View<br>qui permettra d'afficher l'item. |
| GridViewItem.**GetView()** | Renvoie le template de View associé à l'item. |

