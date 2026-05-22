using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B1 RID: 433
	public class KeySignatureBuilder : Object
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x0005ED04 File Offset: 0x0005CF04
		// Note: this type is marked as 'beforefieldinit'.
		static KeySignatureBuilder()
		{
			Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "KeySignatureBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr);
			KeySignatureBuilder.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, "key");
			KeySignatureBuilder.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, "result");
			KeySignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666215);
			KeySignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666216);
			KeySignatureBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666217);
			KeySignatureBuilder.NativeMethodInfoPtr_get_Key_Public_get_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666218);
			KeySignatureBuilder.NativeMethodInfoPtr_set_Key_Public_set_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666219);
			KeySignatureBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666220);
			KeySignatureBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr, 100666221);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0005EDE8 File Offset: 0x0005CFE8
		[CallerCount(0)]
		public unsafe KeySignatureBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0005EE24 File Offset: 0x0005D024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16239, XrefRangeEnd = 16240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySignatureBuilder(MetaMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySignatureBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0005EE70 File Offset: 0x0005D070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16242, RefRangeEnd = 16243, XrefRangeStart = 16240, XrefRangeEnd = 16242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MetaMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
		public unsafe Key Key
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr_get_Key_Public_get_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr_set_Key_Public_set_Void_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0005EF30 File Offset: 0x0005D130
		public unsafe MetaMessage Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0005EF70 File Offset: 0x0005D170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16243, XrefRangeEnd = 16264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySignatureBuilder.NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000865D File Offset: 0x0000685D
		public KeySignatureBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005EFA4 File Offset: 0x0005D1A4
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x00008666 File Offset: 0x00006866
		public unsafe Key key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySignatureBuilder.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySignatureBuilder.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0005EFCC File Offset: 0x0005D1CC
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00008681 File Offset: 0x00006881
		public unsafe MetaMessage result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySignatureBuilder.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySignatureBuilder.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaMessage_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MetaMessage_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Key_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Key_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_MetaMessage_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_Void_0;
	}
}
