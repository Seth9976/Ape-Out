using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine
{
	// Token: 0x02000056 RID: 86
	[StructLayout(2)]
	public struct RectInt
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00021BD8 File Offset: 0x0001FDD8
		// Note: this type is marked as 'beforefieldinit'.
		static RectInt()
		{
			Il2CppClassPointerStore<RectInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectInt>.NativeClassPtr);
			RectInt.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_XMin");
			RectInt.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_YMin");
			RectInt.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Width");
			RectInt.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Height");
			RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663703);
			RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663704);
			RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663705);
			RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663706);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663707);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663708);
			RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100663709);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004909 File Offset: 0x00002B09
		public unsafe int x
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_XMin = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00021D14 File Offset: 0x0001FF14
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004913 File Offset: 0x00002B13
		public unsafe int y
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_YMin = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00021D44 File Offset: 0x0001FF44
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0000495B File Offset: 0x00002B5B
		public unsafe int width
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00021D74 File Offset: 0x0001FF74
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004965 File Offset: 0x00002B65
		public unsafe int height
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487465, XrefRangeEnd = 487475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00021DD0 File Offset: 0x0001FFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487506, RefRangeEnd = 487507, XrefRangeStart = 487475, XrefRangeEnd = 487506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00021E20 File Offset: 0x00020020
		[CallerCount(0)]
		public unsafe bool Equals(RectInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000048F7 File Offset: 0x00002AF7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectInt>.NativeClassPtr, ref this));
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00021E60 File Offset: 0x00020060
		public Vector2 center
		{
			get
			{
				return new Vector2((float)this.x + (float)this.m_Width / 2f, (float)this.y + (float)this.m_Height / 2f);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00021EA4 File Offset: 0x000200A4
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000491D File Offset: 0x00002B1D
		public Vector2Int min
		{
			get
			{
				return new Vector2Int(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00021EC8 File Offset: 0x000200C8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0000493C File Offset: 0x00002B3C
		public Vector2Int max
		{
			get
			{
				return new Vector2Int(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00021EEC File Offset: 0x000200EC
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00021F18 File Offset: 0x00020118
		public int xMin
		{
			get
			{
				return Math.Min(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				int xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00021F44 File Offset: 0x00020144
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00021F70 File Offset: 0x00020170
		public int yMin
		{
			get
			{
				return Math.Min(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				int yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00021F9C File Offset: 0x0002019C
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0000496F File Offset: 0x00002B6F
		public int xMax
		{
			get
			{
				return Math.Max(this.m_XMin, this.m_XMin + this.m_Width);
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00021FC8 File Offset: 0x000201C8
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004980 File Offset: 0x00002B80
		public int yMax
		{
			get
			{
				return Math.Max(this.m_YMin, this.m_YMin + this.m_Height);
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00021FF4 File Offset: 0x000201F4
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004991 File Offset: 0x00002B91
		public Vector2Int position
		{
			get
			{
				return new Vector2Int(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00022018 File Offset: 0x00020218
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x000049AE File Offset: 0x00002BAE
		public Vector2Int size
		{
			get
			{
				return new Vector2Int(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000049CB File Offset: 0x00002BCB
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002203C File Offset: 0x0002023C
		public void ClampToBounds(RectInt bounds)
		{
			this.position = new Vector2Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin));
			this.size = new Vector2Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00022100 File Offset: 0x00020300
		public bool Contains(Vector2Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00022154 File Offset: 0x00020354
		public bool Overlaps(RectInt other)
		{
			return other.xMin < this.xMax && other.xMax > this.xMin && other.yMin < this.yMax && other.yMax > this.yMin;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000221A8 File Offset: 0x000203A8
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000221CC File Offset: 0x000203CC
		public RectInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new RectInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0;

		// Token: 0x040003C8 RID: 968
		[FieldOffset(0)]
		public int m_XMin;

		// Token: 0x040003C9 RID: 969
		[FieldOffset(4)]
		public int m_YMin;

		// Token: 0x040003CA RID: 970
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x040003CB RID: 971
		[FieldOffset(12)]
		public int m_Height;

		// Token: 0x0200041F RID: 1055
		public struct PositionEnumerator
		{
		}
	}
}
