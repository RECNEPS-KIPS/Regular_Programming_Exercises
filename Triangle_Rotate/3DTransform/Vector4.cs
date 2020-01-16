﻿namespace _3DTransform {
    public class Vector4 {
        public double x, y, z, w;

        public Vector4() {

        }
        //有参构造函数
        public Vector4(double x,double y,double z,double w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        //Copy其他向量的值
        public Vector4(Vector4 v) {
            x = v.x;
            y=v.y;
            z = v.z;
            w = v.w;
        }
        //四维向量的减法操作符运算
        public static Vector4 operator -(Vector4 a, Vector4 b) {
            return new Vector4(a.x-b.x,a.y-b.y,a.z-b.z,a.w-b.w);
        }
        //向量叉乘
        public Vector4 Cross(Vector4 v) {
            return new Vector4(this.y*v.z-this.z*v.y,v.x*this.z-this.x*v.z,this.x*v.y-v.x*this.y,0);
        }
        //向量点乘
        public float Dot(Vector4 v) {
            return (float) (this.x * v.x + this.y * v.y + this.z * v.z);
        }
    }
}