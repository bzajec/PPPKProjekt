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
@Table(name = "Vozac")
@XmlRootElement
@NamedQueries({
      @NamedQuery(name = "Vozac.findAll", query = "SELECT v FROM Vozac v")
    , @NamedQuery(name = "Vozac.findByIDVozac", query = "SELECT v FROM Vozac v WHERE v.iDVozac = :iDVozac")
    , @NamedQuery(name = "Vozac.findByName", query = "SELECT v FROM Vozac v WHERE v.name = :name")
    , @NamedQuery(name = "Vozac.findByBrojMobitela", query = "SELECT v FROM Vozac v WHERE v.brojMobitela = :brojMobitela")
    , @NamedQuery(name = "Vozac.findByBrojVozackeDozvole", query = "SELECT v FROM Vozac v WHERE v.brojVozackeDozvole = :brojVozackeDozvole")})


public class Vozac implements Serializable {
    
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDVozac")
    private Integer iDVozac;
    @Basic(optional = false)
    @Column(name = "Name")
    private String name;
    @Basic(optional = false)
    @Column(name = "BrojMobitela")
    private int brojMobitela;
    @Basic(optional = false)
    @Column(name = "BrojVozackeDozvole")
    private int brojVozackeDozvole;
    @OneToMany(mappedBy = "vozacID")
    private List<PutniNalog> putniNalogList;
    
    public Vozac() {
    }

    public Vozac(Integer iDVozac) {
        this.iDVozac = iDVozac;
    }

    public Vozac(Integer iDVozac, String name, int brojMobitela, int brojVozackeDozvole) {
        this.iDVozac = iDVozac;
        this.name = name;
        this.brojMobitela = brojMobitela;
        this.brojVozackeDozvole = brojVozackeDozvole;
    }

    public Integer getIDVozac() {
        return iDVozac;
    }

    public void setIDVozac(Integer iDVozac) {
        this.iDVozac = iDVozac;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getBrojMobitela() {
        return brojMobitela;
    }

    public void setBrojMobitela(int brojMobitela) {
        this.brojMobitela = brojMobitela;
    }

    public int getBrojVozackeDozvole() {
        return brojVozackeDozvole;
    }

    public void setBrojVozackeDozvole(int brojVozackeDozvole) {
        this.brojVozackeDozvole = brojVozackeDozvole;
    }

    @XmlTransient
    public List<PutniNalog> getPutniNalogList() {
        return putniNalogList;
    }

    public void setPutniNalogList(List<PutniNalog> putniNalogList) {
        this.putniNalogList = putniNalogList;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDVozac != null ? iDVozac.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Vozac)) {
            return false;
        }
        Vozac other = (Vozac) object;
        if ((this.iDVozac == null && other.iDVozac != null) || (this.iDVozac != null && !this.iDVozac.equals(other.iDVozac))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "hr.algebra.model.Vozac[ iDVozac=" + iDVozac + " ]";
    }
    
}
