using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class TMP_Asset : ScriptableObject
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000B884 File Offset: 0x00009A84
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Asset()
		{
			Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Asset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr);
			TMP_Asset.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "m_InstanceID");
			TMP_Asset.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "hashCode");
			TMP_Asset.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "material");
			TMP_Asset.NativeFieldInfoPtr_materialHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "materialHashCode");
			TMP_Asset.NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, 100663340);
			TMP_Asset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, 100663341);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000B92C File Offset: 0x00009B2C
		public unsafe int instanceID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450431, XrefRangeEnd = 450432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Asset.NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B968 File Offset: 0x00009B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Asset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Asset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000023AE File Offset: 0x000005AE
		public TMP_Asset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe int m_InstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_m_InstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_m_InstanceID)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000B9CC File Offset: 0x00009BCC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000023D2 File Offset: 0x000005D2
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000023ED File Offset: 0x000005ED
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000BA24 File Offset: 0x00009C24
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000240C File Offset: 0x0000060C
		public unsafe int materialHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_materialHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_materialHashCode)) = value;
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_materialHashCode;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
