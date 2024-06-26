import java.io.*;
public class FileClassEx {

    public static void listDirectory(File dir){
        System.out.println("--------"+dir.getPath()+"의 서브 디렉토리--------");
        File[] subFiles = dir.listFiles();
        for(int i=0; i<subFiles.length; i++){
            File f = subFiles[i];
            long t = f.lastModified();
            System.out.print(f.getName()+"\t파일 크기 : "+f.length());
            System.out.printf("\t수정한 시간 : %tb %td %ta %tT\n",t,t,t,t);


        }
    }
    public static void main(String[] args) {
        File f1 = new File("C:\\Users\\seoil\\Desktop\\system.ini");
//        System.out.println(f1.getPath());
//        System.out.println(f1.getParent());
//        System.out.println(f1.getName());
        String res = "";
        if (f1.isFile()){
            res = "파일";
        }
        if (f1.isDirectory()){
            res = "디렉토리";
        }
        System.out.println(f1.getPath()+"은"+res+"입니다.");
        File f2 = new File("C:\\Users\\seoil\\Desktop\\test_1");
        if(!f2.exists())f2.mkdir();
        listDirectory(new File("C:\\Users\\seoil\\Desktop\\"));
        f2.renameTo(new File("C:\\Users\\seoil\\Desktop\\test_2"));

        listDirectory(new File("C:\\Users\\seoil\\Desktop\\"));

    }
}
