using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2Cpp
{
	// Token: 0x02000011 RID: 17
	public class tnLnhpiMrhDXtaULQduOdMTdeaHr : NativeBuffer
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00010B4C File Offset: 0x0000ED4C
		// Note: this type is marked as 'beforefieldinit'.
		static tnLnhpiMrhDXtaULQduOdMTdeaHr()
		{
			Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "tnLnhpiMrhDXtaULQduOdMTdeaHr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr);
			tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_IJiAcKHemuixEAhwCTGsdoiSQgAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr, "IJiAcKHemuixEAhwCTGsdoiSQgAP");
			tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_tqFHMHvjabRmNGDghYYhfHrLebm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr, "tqFHMHvjabRmNGDghYYhfHrLebm");
			tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr_get_maxDevices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr, 100663806);
			tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr_get_structSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr, 100663807);
			tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr, 100663808);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		public unsafe int XswgCzjUmrolFogVmPhqieAEwXVY
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr_get_maxDevices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public unsafe int lAJQvCJGqXguVDrEQBpzeBTTNNIj
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr_get_structSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00010C58 File Offset: 0x0000EE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352377, XrefRangeEnd = 352378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe tnLnhpiMrhDXtaULQduOdMTdeaHr(int structSize, int maxDevices)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<tnLnhpiMrhDXtaULQduOdMTdeaHr>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref structSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDevices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002C49 File Offset: 0x00000E49
		public tnLnhpiMrhDXtaULQduOdMTdeaHr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002C52 File Offset: 0x00000E52
		public unsafe int IJiAcKHemuixEAhwCTGsdoiSQgAP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_IJiAcKHemuixEAhwCTGsdoiSQgAP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_IJiAcKHemuixEAhwCTGsdoiSQgAP)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00010CD8 File Offset: 0x0000EED8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002C6D File Offset: 0x00000E6D
		public unsafe int tqFHMHvjabRmNGDghYYhfHrLebm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_tqFHMHvjabRmNGDghYYhfHrLebm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(tnLnhpiMrhDXtaULQduOdMTdeaHr.NativeFieldInfoPtr_tqFHMHvjabRmNGDghYYhfHrLebm)) = value;
			}
		}

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_IJiAcKHemuixEAhwCTGsdoiSQgAP;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_tqFHMHvjabRmNGDghYYhfHrLebm;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_maxDevices_Public_get_Int32_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_structSize_Public_get_Int32_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
