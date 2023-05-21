/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PPPK_PDF;

import hr.algebra.model.PutniNalog;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

/**
 *
 * @author Bruno
 */
public class Main {

    
    public static void main(String[] args) {
        EntityManagerFactory emf = null;

        try {

            emf = Persistence.createEntityManagerFactory("JavaPDFPU");
            printServices(emf);

        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (emf != null) {
                emf.close();
            }
        }
    }
    
    private static void printServices(EntityManagerFactory emf) {
         EntityManager em = null;
        try {
            em = emf.createEntityManager();
            em.getTransaction().begin();

             Query query = em.createQuery("select putniNalog from PutniNalog as putniNalog", PutniNalog.class);
             
            try (PDDocument doc = new PDDocument()) {

                PDPage myPage = new PDPage();
                doc.addPage(myPage);

                try (PDPageContentStream cont = new PDPageContentStream(doc, myPage)) {
                    cont.beginText();
                    cont.setFont(PDType1Font.COURIER_BOLD, 8);
                    cont.setLeading(14.5f);

                    cont.newLineAtOffset(25, 700);

                    query.getResultList().forEach((text) -> {
                        try {
                            cont.showText(text.toString());
                             cont.newLine();
                        } catch (IOException ex) {
                            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
                        }
                    });
                    cont.endText();
                }
                doc.save("putniNalozi.pdf");
            }
            em.getTransaction().commit();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }
    
}
