using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	public sealed class TerrainLayer : Object
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00002E2F File Offset: 0x0000102F
		public static void Internal_Create(TerrainLayer layer)
		{
			TerrainLayer.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(layer));
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00005AC4 File Offset: 0x00003CC4
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002E41 File Offset: 0x00001041
		public Texture2D diffuseTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_diffuseTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_diffuseTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00005AF0 File Offset: 0x00003CF0
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002E59 File Offset: 0x00001059
		public Texture2D normalMapTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_normalMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_normalMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00005B1C File Offset: 0x00003D1C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002E71 File Offset: 0x00001071
		public Texture2D maskMapTexture
		{
			get
			{
				IntPtr intPtr = TerrainLayer.get_maskMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				TerrainLayer.set_maskMapTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00005B48 File Offset: 0x00003D48
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002E89 File Offset: 0x00001089
		public Vector2 tileSize
		{
			get
			{
				Vector2 vector;
				this.get_tileSize_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileSize_Injected(ref value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00005B60 File Offset: 0x00003D60
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002E93 File Offset: 0x00001093
		public Vector2 tileOffset
		{
			get
			{
				Vector2 vector;
				this.get_tileOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_tileOffset_Injected(ref value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00005B78 File Offset: 0x00003D78
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002E9D File Offset: 0x0000109D
		public Color specular
		{
			get
			{
				Color color;
				this.get_specular_Injected(out color);
				return color;
			}
			set
			{
				this.set_specular_Injected(ref value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002EA7 File Offset: 0x000010A7
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002EB9 File Offset: 0x000010B9
		public float metallic
		{
			get
			{
				return TerrainLayer.get_metallicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_metallicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002ECC File Offset: 0x000010CC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002EDE File Offset: 0x000010DE
		public float smoothness
		{
			get
			{
				return TerrainLayer.get_smoothnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_smoothnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002EF1 File Offset: 0x000010F1
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002F03 File Offset: 0x00001103
		public float normalScale
		{
			get
			{
				return TerrainLayer.get_normalScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TerrainLayer.set_normalScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00005B90 File Offset: 0x00003D90
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002F16 File Offset: 0x00001116
		public Vector4 diffuseRemapMin
		{
			get
			{
				Vector4 vector;
				this.get_diffuseRemapMin_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_diffuseRemapMin_Injected(ref value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002F20 File Offset: 0x00001120
		public Vector4 diffuseRemapMax
		{
			get
			{
				Vector4 vector;
				this.get_diffuseRemapMax_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_diffuseRemapMax_Injected(ref value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005BC0 File Offset: 0x00003DC0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002F2A File Offset: 0x0000112A
		public Vector4 maskMapRemapMin
		{
			get
			{
				Vector4 vector;
				this.get_maskMapRemapMin_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_maskMapRemapMin_Injected(ref value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00005BD8 File Offset: 0x00003DD8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002F34 File Offset: 0x00001134
		public Vector4 maskMapRemapMax
		{
			get
			{
				Vector4 vector;
				this.get_maskMapRemapMax_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_maskMapRemapMax_Injected(ref value);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002F3E File Offset: 0x0000113E
		public void get_tileSize_Injected(out Vector2 ret)
		{
			TerrainLayer.get_tileSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002F51 File Offset: 0x00001151
		public void set_tileSize_Injected(ref Vector2 value)
		{
			TerrainLayer.set_tileSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002F64 File Offset: 0x00001164
		public void get_tileOffset_Injected(out Vector2 ret)
		{
			TerrainLayer.get_tileOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002F77 File Offset: 0x00001177
		public void set_tileOffset_Injected(ref Vector2 value)
		{
			TerrainLayer.set_tileOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002F8A File Offset: 0x0000118A
		public void get_specular_Injected(out Color ret)
		{
			TerrainLayer.get_specular_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002F9D File Offset: 0x0000119D
		public void set_specular_Injected(ref Color value)
		{
			TerrainLayer.set_specular_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002FB0 File Offset: 0x000011B0
		public void get_diffuseRemapMin_Injected(out Vector4 ret)
		{
			TerrainLayer.get_diffuseRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002FC3 File Offset: 0x000011C3
		public void set_diffuseRemapMin_Injected(ref Vector4 value)
		{
			TerrainLayer.set_diffuseRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002FD6 File Offset: 0x000011D6
		public void get_diffuseRemapMax_Injected(out Vector4 ret)
		{
			TerrainLayer.get_diffuseRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002FE9 File Offset: 0x000011E9
		public void set_diffuseRemapMax_Injected(ref Vector4 value)
		{
			TerrainLayer.set_diffuseRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002FFC File Offset: 0x000011FC
		public void get_maskMapRemapMin_Injected(out Vector4 ret)
		{
			TerrainLayer.get_maskMapRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000300F File Offset: 0x0000120F
		public void set_maskMapRemapMin_Injected(ref Vector4 value)
		{
			TerrainLayer.set_maskMapRemapMin_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003022 File Offset: 0x00001222
		public void get_maskMapRemapMax_Injected(out Vector4 ret)
		{
			TerrainLayer.get_maskMapRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00003035 File Offset: 0x00001235
		public void set_maskMapRemapMax_Injected(ref Vector4 value)
		{
			TerrainLayer.set_maskMapRemapMax_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000D5 RID: 213
		private static readonly TerrainLayer.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<TerrainLayer.Internal_CreateDelegate>("UnityEngine.TerrainLayer::Internal_Create");

		// Token: 0x040000D6 RID: 214
		private static readonly TerrainLayer.get_diffuseTextureDelegate get_diffuseTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseTextureDelegate>("UnityEngine.TerrainLayer::get_diffuseTexture");

		// Token: 0x040000D7 RID: 215
		private static readonly TerrainLayer.set_diffuseTextureDelegate set_diffuseTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseTextureDelegate>("UnityEngine.TerrainLayer::set_diffuseTexture");

		// Token: 0x040000D8 RID: 216
		private static readonly TerrainLayer.get_normalMapTextureDelegate get_normalMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_normalMapTextureDelegate>("UnityEngine.TerrainLayer::get_normalMapTexture");

		// Token: 0x040000D9 RID: 217
		private static readonly TerrainLayer.set_normalMapTextureDelegate set_normalMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_normalMapTextureDelegate>("UnityEngine.TerrainLayer::set_normalMapTexture");

		// Token: 0x040000DA RID: 218
		private static readonly TerrainLayer.get_maskMapTextureDelegate get_maskMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapTextureDelegate>("UnityEngine.TerrainLayer::get_maskMapTexture");

		// Token: 0x040000DB RID: 219
		private static readonly TerrainLayer.set_maskMapTextureDelegate set_maskMapTextureDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapTextureDelegate>("UnityEngine.TerrainLayer::set_maskMapTexture");

		// Token: 0x040000DC RID: 220
		private static readonly TerrainLayer.get_metallicDelegate get_metallicDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_metallicDelegate>("UnityEngine.TerrainLayer::get_metallic");

		// Token: 0x040000DD RID: 221
		private static readonly TerrainLayer.set_metallicDelegate set_metallicDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_metallicDelegate>("UnityEngine.TerrainLayer::set_metallic");

		// Token: 0x040000DE RID: 222
		private static readonly TerrainLayer.get_smoothnessDelegate get_smoothnessDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_smoothnessDelegate>("UnityEngine.TerrainLayer::get_smoothness");

		// Token: 0x040000DF RID: 223
		private static readonly TerrainLayer.set_smoothnessDelegate set_smoothnessDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_smoothnessDelegate>("UnityEngine.TerrainLayer::set_smoothness");

		// Token: 0x040000E0 RID: 224
		private static readonly TerrainLayer.get_normalScaleDelegate get_normalScaleDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_normalScaleDelegate>("UnityEngine.TerrainLayer::get_normalScale");

		// Token: 0x040000E1 RID: 225
		private static readonly TerrainLayer.set_normalScaleDelegate set_normalScaleDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_normalScaleDelegate>("UnityEngine.TerrainLayer::set_normalScale");

		// Token: 0x040000E2 RID: 226
		private static readonly TerrainLayer.get_tileSize_InjectedDelegate get_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileSize_Injected");

		// Token: 0x040000E3 RID: 227
		private static readonly TerrainLayer.set_tileSize_InjectedDelegate set_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileSize_Injected");

		// Token: 0x040000E4 RID: 228
		private static readonly TerrainLayer.get_tileOffset_InjectedDelegate get_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileOffset_Injected");

		// Token: 0x040000E5 RID: 229
		private static readonly TerrainLayer.set_tileOffset_InjectedDelegate set_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileOffset_Injected");

		// Token: 0x040000E6 RID: 230
		private static readonly TerrainLayer.get_specular_InjectedDelegate get_specular_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_specular_InjectedDelegate>("UnityEngine.TerrainLayer::get_specular_Injected");

		// Token: 0x040000E7 RID: 231
		private static readonly TerrainLayer.set_specular_InjectedDelegate set_specular_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_specular_InjectedDelegate>("UnityEngine.TerrainLayer::set_specular_Injected");

		// Token: 0x040000E8 RID: 232
		private static readonly TerrainLayer.get_diffuseRemapMin_InjectedDelegate get_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMin_Injected");

		// Token: 0x040000E9 RID: 233
		private static readonly TerrainLayer.set_diffuseRemapMin_InjectedDelegate set_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMin_Injected");

		// Token: 0x040000EA RID: 234
		private static readonly TerrainLayer.get_diffuseRemapMax_InjectedDelegate get_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMax_Injected");

		// Token: 0x040000EB RID: 235
		private static readonly TerrainLayer.set_diffuseRemapMax_InjectedDelegate set_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMax_Injected");

		// Token: 0x040000EC RID: 236
		private static readonly TerrainLayer.get_maskMapRemapMin_InjectedDelegate get_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMin_Injected");

		// Token: 0x040000ED RID: 237
		private static readonly TerrainLayer.set_maskMapRemapMin_InjectedDelegate set_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMin_Injected");

		// Token: 0x040000EE RID: 238
		private static readonly TerrainLayer.get_maskMapRemapMax_InjectedDelegate get_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.get_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMax_Injected");

		// Token: 0x040000EF RID: 239
		private static readonly TerrainLayer.set_maskMapRemapMax_InjectedDelegate set_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<TerrainLayer.set_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMax_Injected");

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x06000300 RID: 768
		private delegate void Internal_CreateDelegate(IntPtr layer);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06000302 RID: 770
		private delegate IntPtr get_diffuseTextureDelegate(IntPtr @this);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000304 RID: 772
		private delegate void set_diffuseTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x06000306 RID: 774
		private delegate IntPtr get_normalMapTextureDelegate(IntPtr @this);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x06000308 RID: 776
		private delegate void set_normalMapTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x0600030A RID: 778
		private delegate IntPtr get_maskMapTextureDelegate(IntPtr @this);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x0600030C RID: 780
		private delegate void set_maskMapTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x0600030E RID: 782
		private delegate float get_metallicDelegate(IntPtr @this);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000310 RID: 784
		private delegate void set_metallicDelegate(IntPtr @this, float value);

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000312 RID: 786
		private delegate float get_smoothnessDelegate(IntPtr @this);

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000314 RID: 788
		private delegate void set_smoothnessDelegate(IntPtr @this, float value);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000316 RID: 790
		private delegate float get_normalScaleDelegate(IntPtr @this);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000318 RID: 792
		private delegate void set_normalScaleDelegate(IntPtr @this, float value);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x0600031A RID: 794
		private delegate void get_tileSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000BC RID: 188
		// (Invoke) Token: 0x0600031C RID: 796
		private delegate void set_tileSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000BD RID: 189
		// (Invoke) Token: 0x0600031E RID: 798
		private delegate void get_tileOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000320 RID: 800
		private delegate void set_tileOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000BF RID: 191
		// (Invoke) Token: 0x06000322 RID: 802
		private delegate void get_specular_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000324 RID: 804
		private delegate void set_specular_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x06000326 RID: 806
		private delegate void get_diffuseRemapMin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C2 RID: 194
		// (Invoke) Token: 0x06000328 RID: 808
		private delegate void set_diffuseRemapMin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x0600032A RID: 810
		private delegate void get_diffuseRemapMax_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C4 RID: 196
		// (Invoke) Token: 0x0600032C RID: 812
		private delegate void set_diffuseRemapMax_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x0600032E RID: 814
		private delegate void get_maskMapRemapMin_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000330 RID: 816
		private delegate void set_maskMapRemapMin_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x06000332 RID: 818
		private delegate void get_maskMapRemapMax_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000C8 RID: 200
		// (Invoke) Token: 0x06000334 RID: 820
		private delegate void set_maskMapRemapMax_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
