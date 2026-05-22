using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000172 RID: 370
	[StructLayout(2)]
	public struct LODParameters
	{
		// Token: 0x06001BE6 RID: 7142 RVA: 0x0006844C File Offset: 0x0006664C
		// Note: this type is marked as 'beforefieldinit'.
		static LODParameters()
		{
			Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LODParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
			LODParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_IsOrthographic");
			LODParameters.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPosition");
			LODParameters.NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_FieldOfView");
			LODParameters.NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_OrthoSize");
			LODParameters.NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPixelHeight");
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665806);
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665807);
			LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100665808);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0006851C File Offset: 0x0006671C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502979, RefRangeEnd = 502980, XrefRangeStart = 502979, XrefRangeEnd = 502979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LODParameters other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0006855C File Offset: 0x0006675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502980, XrefRangeEnd = 502983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000685A0 File Offset: 0x000667A0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0000F002 File Offset: 0x0000D202
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x000685D0 File Offset: 0x000667D0
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000F014 File Offset: 0x0000D214
		public bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			set
			{
				this.m_IsOrthographic = Convert.ToInt32(value);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x000685F0 File Offset: 0x000667F0
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0000F023 File Offset: 0x0000D223
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00068608 File Offset: 0x00066808
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0000F02D File Offset: 0x0000D22D
		public float fieldOfView
		{
			get
			{
				return this.m_FieldOfView;
			}
			set
			{
				this.m_FieldOfView = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00068620 File Offset: 0x00066820
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0000F037 File Offset: 0x0000D237
		public float orthoSize
		{
			get
			{
				return this.m_OrthoSize;
			}
			set
			{
				this.m_OrthoSize = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00068638 File Offset: 0x00066838
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0000F041 File Offset: 0x0000D241
		public int cameraPixelHeight
		{
			get
			{
				return this.m_CameraPixelHeight;
			}
			set
			{
				this.m_CameraPixelHeight = value;
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00068650 File Offset: 0x00066850
		public static bool operator ==(LODParameters left, LODParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0006866C File Offset: 0x0006686C
		public static bool operator !=(LODParameters left, LODParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeFieldInfoPtr_m_FieldOfView;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeFieldInfoPtr_m_OrthoSize;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040015BC RID: 5564
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x040015BD RID: 5565
		[FieldOffset(4)]
		public Vector3 m_CameraPosition;

		// Token: 0x040015BE RID: 5566
		[FieldOffset(16)]
		public float m_FieldOfView;

		// Token: 0x040015BF RID: 5567
		[FieldOffset(20)]
		public float m_OrthoSize;

		// Token: 0x040015C0 RID: 5568
		[FieldOffset(24)]
		public int m_CameraPixelHeight;
	}
}
