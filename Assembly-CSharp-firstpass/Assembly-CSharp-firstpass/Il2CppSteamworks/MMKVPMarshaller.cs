using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000017 RID: 23
	public class MMKVPMarshaller : Object
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00011224 File Offset: 0x0000F424
		// Note: this type is marked as 'beforefieldinit'.
		static MMKVPMarshaller()
		{
			Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MMKVPMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr);
			MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, "m_pNativeArray");
			MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, "m_pArrayEntries");
			MMKVPMarshaller.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100663512);
			MMKVPMarshaller.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100663513);
			MMKVPMarshaller.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr, 100663514);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000112B8 File Offset: 0x0000F4B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 2914, RefRangeEnd = 2919, XrefRangeStart = 2875, XrefRangeEnd = 2914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MMKVPMarshaller(Il2CppReferenceArray<MatchMakingKeyValuePair_t> filters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MMKVPMarshaller>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MMKVPMarshaller.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00011304 File Offset: 0x0000F504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2919, XrefRangeEnd = 2926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MMKVPMarshaller.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00011340 File Offset: 0x0000F540
		[CallerCount(0)]
		public unsafe static implicit operator IntPtr(MMKVPMarshaller that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MMKVPMarshaller.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000027E7 File Offset: 0x000009E7
		public MMKVPMarshaller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00011384 File Offset: 0x0000F584
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000027F0 File Offset: 0x000009F0
		public unsafe IntPtr m_pNativeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pNativeArray)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000113AC File Offset: 0x0000F5AC
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000280B File Offset: 0x00000A0B
		public unsafe IntPtr m_pArrayEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MMKVPMarshaller.NativeFieldInfoPtr_m_pArrayEntries)) = value;
			}
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_m_pNativeArray;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_m_pArrayEntries;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_MMKVPMarshaller_0;
	}
}
