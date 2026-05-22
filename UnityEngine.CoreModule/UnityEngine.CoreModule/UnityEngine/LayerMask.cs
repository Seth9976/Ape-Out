using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DA RID: 218
	[StructLayout(2)]
	public struct LayerMask
	{
		// Token: 0x0600131B RID: 4891 RVA: 0x0004D858 File Offset: 0x0004BA58
		// Note: this type is marked as 'beforefieldinit'.
		static LayerMask()
		{
			Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LayerMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
			LayerMask.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, "m_Mask");
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664925);
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664926);
			LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664927);
			LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664928);
			LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100664929);
			LayerMask.LayerToNameDelegateField = IL2CPP.ResolveICall<LayerMask.LayerToNameDelegate>("UnityEngine.LayerMask::LayerToName");
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0004D910 File Offset: 0x0004BB10
		[CallerCount(0)]
		public unsafe static implicit operator int(LayerMask mask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0004D950 File Offset: 0x0004BB50
		[CallerCount(0)]
		public unsafe static implicit operator LayerMask(int intVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0004D990 File Offset: 0x0004BB90
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x0000ADA9 File Offset: 0x00008FA9
		public unsafe int value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Mask = value;
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 496078, RefRangeEnd = 496091, XrefRangeStart = 496074, XrefRangeEnd = 496078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NameToLayer(string layerName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(layerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0004DA04 File Offset: 0x0004BC04
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 496094, RefRangeEnd = 496145, XrefRangeStart = 496091, XrefRangeEnd = 496094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMask([Optional] Il2CppStringArray layerNames)
		{
			if (layerNames == null)
			{
				layerNames = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layerNames);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0000AD8A File Offset: 0x00008F8A
		public static int GetMask(params string[] layerNames)
		{
			return LayerMask.GetMask(new Il2CppStringArray(layerNames));
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0000AD97 File Offset: 0x00008F97
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, ref this));
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0004DA54 File Offset: 0x0004BC54
		public static string LayerToName(int layer)
		{
			IntPtr intPtr = LayerMask.LayerToNameDelegateField(layer);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0;

		// Token: 0x04000F35 RID: 3893
		[FieldOffset(0)]
		public int m_Mask;

		// Token: 0x04000F36 RID: 3894
		private static readonly LayerMask.LayerToNameDelegate LayerToNameDelegateField;

		// Token: 0x020007B1 RID: 1969
		// (Invoke) Token: 0x06002D5F RID: 11615
		private delegate IntPtr LayerToNameDelegate(int layer);
	}
}
