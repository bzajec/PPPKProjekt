/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.List;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Bruno
 */

@Entity
@Table(name = "Item")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Item.findAll", query = "SELECT i FROM Item i")
    , @NamedQuery(name = "Item.findByIDItem", query = "SELECT i FROM Item i WHERE i.iDItem = :iDItem")
    , @NamedQuery(name = "Item.findByItemName", query = "SELECT i FROM Item i WHERE i.itemName = :itemName")})

public class Item implements Serializable {
    
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDItem")
    private Integer iDItem;
    @Basic(optional = false)
    @Column(name = "ItemName")
    private String itemName;
    @OneToMany(mappedBy = "itemID")
    private List<Servis> servisList;
    
    public Item() {
    }

    public Item(Integer iDItem) {
        this.iDItem = iDItem;
    }

    public Item(Integer iDItem, String itemName) {
        this.iDItem = iDItem;
        this.itemName = itemName;
    }

    public Integer getIDItem() {
        return iDItem;
    }

    public void setIDItem(Integer iDItem) {
        this.iDItem = iDItem;
    }

    public String getItemName() {
        return itemName;
    }

    public void setItemName(String itemName) {
        this.itemName = itemName;
    }

    @XmlTransient
    public List<Servis> getServisList() {
        return servisList;
    }

    public void setServisList(List<Servis> servisList) {
        this.servisList = servisList;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDItem != null ? iDItem.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Item)) {
            return false;
        }
        Item other = (Item) object;
        if ((this.iDItem == null && other.iDItem != null) || (this.iDItem != null && !this.iDItem.equals(other.iDItem))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Item[ iDItem=" + iDItem + " ]";
    }
    
}
