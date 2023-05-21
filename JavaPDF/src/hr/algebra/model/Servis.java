/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Bruno
 */

@Entity
@Table(name = "Servis")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Servis.findAll", query = "SELECT s FROM Servis s")
    , @NamedQuery(name = "Servis.findByIDServis", query = "SELECT s FROM Servis s WHERE s.iDServis = :iDServis")})

public class Servis implements Serializable {
    
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDServis")
    private Integer iDServis;
    @JoinColumn(name = "ItemID", referencedColumnName = "IDItem")
    @ManyToOne
    private Item itemID;
    @JoinColumn(name = "VoziloID", referencedColumnName = "IDVozilo")
    @ManyToOne
    private Vozilo voziloID;
    
    public Servis() {
    }

    public Servis(Integer iDServis) {
        this.iDServis = iDServis;
    }

    public Integer getIDServis() {
        return iDServis;
    }

    public void setIDServis(Integer iDServis) {
        this.iDServis = iDServis;
    }

    public Item getItemID() {
        return itemID;
    }

    public void setItemID(Item itemID) {
        this.itemID = itemID;
    }

    public Vozilo getVoziloID() {
        return voziloID;
    }

    public void setVoziloID(Vozilo voziloID) {
        this.voziloID = voziloID;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDServis != null ? iDServis.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Servis)) {
            return false;
        }
        Servis other = (Servis) object;
        if ((this.iDServis == null && other.iDServis != null) || (this.iDServis != null && !this.iDServis.equals(other.iDServis))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Servis[ iDServis=" + iDServis + " ]";
    }
    
}
