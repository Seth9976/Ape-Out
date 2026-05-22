using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004F RID: 79
	public static class TimelineUndo : Object
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x00018BA0 File Offset: 0x00016DA0
		// Note: this type is marked as 'beforefieldinit'.
		static TimelineUndo()
		{
			Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineUndo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr);
			TimelineUndo.NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664147);
			TimelineUndo.NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664148);
			TimelineUndo.NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664149);
			TimelineUndo.NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664150);
			TimelineUndo.NativeMethodInfoPtr_UndoName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664151);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00018C34 File Offset: 0x00016E34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 480340, RefRangeEnd = 480345, XrefRangeStart = 480324, XrefRangeEnd = 480340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timeline);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thingToDirty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectToDestroy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineUndo.NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00018C90 File Offset: 0x00016E90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushUndo(Il2CppReferenceArray<Object> thingsToDirty, string operation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thingsToDirty);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineUndo.NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushUndo(Object thingToDirty, string operation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thingToDirty);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineUndo.NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00018D20 File Offset: 0x00016F20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCreatedObjectUndo(Object thingCreated, string operation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thingCreated);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineUndo.NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00018D68 File Offset: 0x00016F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480345, XrefRangeEnd = 480348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UndoName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineUndo.NativeMethodInfoPtr_UndoName_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00003AE2 File Offset: 0x00001CE2
		public TimelineUndo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_UndoName_Private_Static_String_String_0;
	}
}
