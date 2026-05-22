using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035D RID: 861
	public sealed class BinaryCrossAppDomainString : Object
	{
		// Token: 0x060037D9 RID: 14297 RVA: 0x00110238 File Offset: 0x0010E438
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainString()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr);
			BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "objectId");
			BinaryCrossAppDomainString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, "value");
			BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671910);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671911);
			BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr, 100671912);
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x001102CC File Offset: 0x0010E4CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x00110308 File Offset: 0x0010E508
		[CallerCount(0)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x0011034C File Offset: 0x0010E54C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainString.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x00013F65 File Offset: 0x00012165
		public BinaryCrossAppDomainString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x00110380 File Offset: 0x0010E580
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x00013F6E File Offset: 0x0001216E
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x001103A8 File Offset: 0x0010E5A8
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x00013F89 File Offset: 0x00012189
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04002EE7 RID: 12007
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002EE8 RID: 12008
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002EE9 RID: 12009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EEA RID: 12010
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
