using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001A6 RID: 422
	public class InvalidShortMessageEventArgs : EventArgs
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x0005D950 File Offset: 0x0005BB50
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidShortMessageEventArgs()
		{
			Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "InvalidShortMessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr);
			InvalidShortMessageEventArgs.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr, "message");
			InvalidShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr, 100666172);
			InvalidShortMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr, 100666173);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0005D9BC File Offset: 0x0005BBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16155, XrefRangeEnd = 16158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidShortMessageEventArgs(int message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidShortMessageEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidShortMessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0005DA04 File Offset: 0x0005BC04
		public unsafe int Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidShortMessageEventArgs.NativeMethodInfoPtr_get_Message_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00008435 File Offset: 0x00006635
		public InvalidShortMessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0005DA40 File Offset: 0x0005BC40
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0000843E File Offset: 0x0000663E
		public unsafe int message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidShortMessageEventArgs.NativeFieldInfoPtr_message);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidShortMessageEventArgs.NativeFieldInfoPtr_message)) = value;
			}
		}

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_Int32_0;
	}
}
