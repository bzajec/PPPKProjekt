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
@Table(name = "PutniNalog")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "PutniNalog.findAll", query = "SELECT p FROM PutniNalog p")
    , @NamedQuery(name = "PutniNalog.findByIDPutniNalog", query = "SELECT p FROM PutniNalog p WHERE p.iDPutniNalog = :iDPutniNalog")
    , @NamedQuery(name = "PutniNalog.findByTip", query = "SELECT p FROM PutniNalog p WHERE p.tip = :tip")
    , @NamedQuery(name = "PutniNalog.findByPocetniGrad", query = "SELECT p FROM PutniNalog p WHERE p.pocetniGrad = :pocetniGrad")
    , @NamedQuery(name = "PutniNalog.findByZavrsniGrad", query = "SELECT p FROM PutniNalog p WHERE p.zavrsniGrad = :zavrsniGrad")
    , @NamedQuery(name = "PutniNalog.findByOcekivaniDani", query = "SELECT p FROM PutniNalog p WHERE p.ocekivaniDani = :ocekivaniDani")
    , @NamedQuery(name = "PutniNalog.findByKilometri", query = "SELECT p FROM PutniNalog p WHERE p.kilometri = :kilometri")
    , @NamedQuery(name = "PutniNalog.findByBrzina", query = "SELECT p FROM PutniNalog p WHERE p.brzina = :brzina")
    , @NamedQuery(name = "PutniNalog.findByGorivo", query = "SELECT p FROM PutniNalog p WHERE p.gorivo = :gorivo")})

public class PutniNalog implements Serializable {
    
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDPutniNalog")
    private Integer iDPutniNalog;
    @Column(name = "Tip")
    private String tip;
    @Basic(optional = false)
    @Column(name = "PocetniGrad")
    private String pocetniGrad;
    @Basic(optional = false)
    @Column(name = "ZavrsniGrad")
    private String zavrsniGrad;
    @Basic(optional = false)
    @Column(name = "OcekivaniDani")
    private int ocekivaniDani;
    @Basic(optional = false)
    @Column(name = "Kilometri")
    private int kilometri;
    @Basic(optional = false)
    @Column(name = "Brzina")
    private int brzina;
    @Basic(optional = false)
    @Column(name = "Gorivo")
    private int gorivo;
    @JoinColumn(name = "VozacID", referencedColumnName = "IDVozac")
    @ManyToOne
    private Vozac vozacID;
    @JoinColumn(name = "VoziloID", referencedColumnName = "IDVozilo")
    @ManyToOne
    private Vozilo voziloID;
    
    public PutniNalog() {
    }

    public PutniNalog(Integer iDPutniNalog) {
        this.iDPutniNalog = iDPutniNalog;
    }

    public PutniNalog(Integer iDPutniNalog, String pocetniGrad, String zavrsniGrad, int ocekivaniDani, int kilometri, int brzina, int gorivo) {
        this.iDPutniNalog = iDPutniNalog;
        this.pocetniGrad = pocetniGrad;
        this.zavrsniGrad = zavrsniGrad;
        this.ocekivaniDani = ocekivaniDani;
        this.kilometri = kilometri;
        this.brzina = brzina;
        this.gorivo = gorivo;
    }

    public Integer getIDPutniNalog() {
        return iDPutniNalog;
    }

    public void setIDPutniNalog(Integer iDPutniNalog) {
        this.iDPutniNalog = iDPutniNalog;
    }

    public String getTip() {
        return tip;
    }

    public void setTip(String tip) {
        this.tip = tip;
    }

    public String getPocetniGrad() {
        return pocetniGrad;
    }

    public void setPocetniGrad(String pocetniGrad) {
        this.pocetniGrad = pocetniGrad;
    }

    public String getZavrsniGrad() {
        return zavrsniGrad;
    }

    public void setZavrsniGrad(String zavrsniGrad) {
        this.zavrsniGrad = zavrsniGrad;
    }

    public int getOcekivaniDani() {
        return ocekivaniDani;
    }

    public void setOcekivaniDani(int ocekivaniDani) {
        this.ocekivaniDani = ocekivaniDani;
    }

    public int getKilometri() {
        return kilometri;
    }

    public void setKilometri(int kilometri) {
        this.kilometri = kilometri;
    }

    public int getBrzina() {
        return brzina;
    }

    public void setBrzina(int brzina) {
        this.brzina = brzina;
    }

    public int getGorivo() {
        return gorivo;
    }

    public void setGorivo(int gorivo) {
        this.gorivo = gorivo;
    }

    public Vozac getVozacID() {
        return vozacID;
    }

    public void setVozacID(Vozac vozacID) {
        this.vozacID = vozacID;
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
        hash += (iDPutniNalog != null ? iDPutniNalog.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof PutniNalog)) {
            return false;
        }
        PutniNalog other = (PutniNalog) object;
        if ((this.iDPutniNalog == null && other.iDPutniNalog != null) || (this.iDPutniNalog != null && !this.iDPutniNalog.equals(other.iDPutniNalog))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Tip Naloga - " + tip + "; Pocetni Grad - " + pocetniGrad + "; Zavrsni Grad - " + zavrsniGrad + "; Ocekivano Dana - " + ocekivaniDani + "; Inic stanje kilometara - " + kilometri +"; Brzina - " + brzina + "; Potroseno Goriva - " + gorivo +"";
    }
    
}
