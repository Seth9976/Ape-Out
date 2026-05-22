using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x0200019C RID: 412
	public class NoOpEventArgs : EventArgs
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x0005B068 File Offset: 0x00059268
		// Note: this type is marked as 'beforefieldinit'.
		static NoOpEventArgs()
		{
			Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "NoOpEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr);
			NoOpEventArgs.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr, "data");
			NoOpEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr, 100666075);
			NoOpEventArgs.NativeMethodInfoPtr_get_Data_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr, 100666076);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0005B0D4 File Offset: 0x000592D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15564, XrefRangeEnd = 15567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoOpEventArgs(int data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoOpEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoOpEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0005B11C File Offset: 0x0005931C
		public unsafe int Data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoOpEventArgs.NativeMethodInfoPtr_get_Data_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000080D9 File Offset: 0x000062D9
		public NoOpEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x0005B158 File Offset: 0x00059358
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x000080E2 File Offset: 0x000062E2
		public unsafe int data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoOpEventArgs.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoOpEventArgs.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Int32_0;
	}
}
