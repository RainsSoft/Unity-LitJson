#if !JSON_STANDALONE

using UnityEngine;
using System;
using System.Collections;

using LitJson.Extensions;

namespace LitJson {

	#if UNITY_EDITOR
	[UnityEditor.InitializeOnLoad]
	#endif
	public static class UnityTypeBindings {

		static bool registerd;

		static UnityTypeBindings(){
			Register();
		}

		public static void Register(){

			if(registerd) return;
			registerd = true;

			// If you seralize using WriteProperty()
			// LitJson will attempt to bind property
			// names to class members instead of using
			// an importer.

			// -- Type
			JsonMapper.RegisterExporter<Type>((v,w) => {
				w.Write(v.FullName);
			});
			
			JsonMapper.RegisterImporter<string,Type>((s) => {
				return Type.GetType(s);
			});
            //DateTimeOffset
            //Action<DateTimeOffset, JsonWriter> writeDateTimeOffset = (v, w) => {
            //    //{"D1":"2018-03-21T03:54:36.2747187Z","D2":"2018-03-21T03:54:36.2747187+00:00"}
            //    w.WriteObjectStart();
            //    //w.WriteProperty("D1", string.Format("{0}-{1}-{2}T{3}:{4}:{5}Z",
            //    //    v.Year,v.Month,v.Date,
            //    //    v.Hour,v.Minute,v.Second+v.Millisecond*0.001f));
            //    w.WriteProperty("D2", string.Format("{0}-{1}-{2}T{3}:{4}:{5}+{6}:{7}",
            //         v.Year, v.Month, v.Date,
            //         v.Hour, v.Minute, v.Second + v.Millisecond * 0.001f,
            //         //时区
            //         "00","00"
            //         ));
            //    w.WriteObjectEnd();

            //};
            //JsonMapper.RegisterExporter<DateTimeOffset>((v,w)=> {
            //    writeDateTimeOffset(v,w);
            //});
            ////Action<DateTimeOffset, JsonReader> readDateTimeOffset=((v,r)=> {
            ////    //怎么读呢
            ////});
            ////JsonMapper.RegisterImporter((s) => {
            ////    return 
            ////});
            //JsonMapper.RegisterFactory<DateTimeOffset>(()=> {
            //    return new DateTimeOffset();
            //});
            // -- Vector2
            Action<Vector2,JsonWriter> writeVector2 = (v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("x",v.x);
				w.WriteProperty("y",v.y);
				w.WriteObjectEnd();
			};

			JsonMapper.RegisterExporter<Vector2>((v,w) => {
				writeVector2(v,w);
			});

			// -- Vector3
			Action<Vector3,JsonWriter> writeVector3 = (v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("x",v.x);
				w.WriteProperty("y",v.y);
				w.WriteProperty("z",v.z);
				w.WriteObjectEnd();
			};

			JsonMapper.RegisterExporter<Vector3>((v,w) => {
				writeVector3(v,w);
			});

			// -- Vector4
			JsonMapper.RegisterExporter<Vector4>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("x",v.x);
				w.WriteProperty("y",v.y);
				w.WriteProperty("z",v.z);
				w.WriteProperty("w",v.w);
				w.WriteObjectEnd();
			});

			// -- Quaternion
			JsonMapper.RegisterExporter<Quaternion>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("x",v.x);
				w.WriteProperty("y",v.y);
				w.WriteProperty("z",v.z);
				w.WriteProperty("w",v.w);
				w.WriteObjectEnd();
			});

			// -- Color
			JsonMapper.RegisterExporter<Color>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("r",v.r);
				w.WriteProperty("g",v.g);
				w.WriteProperty("b",v.b);
				w.WriteProperty("a",v.a);
				w.WriteObjectEnd();
			});

			// -- Color32
			JsonMapper.RegisterExporter<Color32>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("r",v.r);
				w.WriteProperty("g",v.g);
				w.WriteProperty("b",v.b);
				w.WriteProperty("a",v.a);
				w.WriteObjectEnd();
			});

			// -- Bounds
			JsonMapper.RegisterExporter<Bounds>((v,w) => {
				w.WriteObjectStart();

				w.WritePropertyName("center");
				writeVector3(v.center,w);

				w.WritePropertyName("size");
				writeVector3(v.size,w);

				w.WriteObjectEnd();
			});

			// -- Rect
			JsonMapper.RegisterExporter<Rect>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("x",v.x);
				w.WriteProperty("y",v.y);
				w.WriteProperty("width",v.width);
				w.WriteProperty("height",v.height);
				w.WriteObjectEnd();
			});

			// -- RectOffset
			JsonMapper.RegisterExporter<RectOffset>((v,w) => {
				w.WriteObjectStart();
				w.WriteProperty("top",v.top);
				w.WriteProperty("left",v.left);
				w.WriteProperty("bottom",v.bottom);
				w.WriteProperty("right",v.right);
				w.WriteObjectEnd();
			});

		}

	}
}
#endif
