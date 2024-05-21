import java.io.*;

public class BinaryCopy {
    public static void main(String[] args){
        File src = new File("C:\\Users\\seoil\\Desktop\\img.png"); // 원본 파일 경로명
        File dest = new File("c:/Temp/back.png"); // 복사 파일 경로명
        int c;
        try {
            FileInputStream fi = new FileInputStream(src);
            FileOutputStream fo = new FileOutputStream(dest);
            while((c = fi.read()) != -1) {
                fo.write((byte)c);
            }
            fi.close();
            fo.close();
            System.out.println( src.getPath()+ "를 " + dest.getPath()+ "로 복사하였습니다.");
        } catch (IOException e) {
            System.out.println("파일 복사 오류");
        }
    }
}
