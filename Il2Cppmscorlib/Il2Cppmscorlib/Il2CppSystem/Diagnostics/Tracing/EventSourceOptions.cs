using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CF RID: 1231
	[StructLayout(2)]
	public struct EventSourceOptions
	{
		// Token: 0x060049A1 RID: 18849 RVA: 0x00154978 File Offset: 0x00152B78
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceOptions()
		{
			Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr);
			EventSourceOptions.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "keywords");
			EventSourceOptions.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "tags");
			EventSourceOptions.NativeFieldInfoPtr_activityOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "activityOptions");
			EventSourceOptions.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "level");
			EventSourceOptions.NativeFieldInfoPtr_opcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "opcode");
			EventSourceOptions.NativeFieldInfoPtr_valuesSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, "valuesSet");
			EventSourceOptions.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100674307);
			EventSourceOptions.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100674308);
			EventSourceOptions.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, 100674309);
		}

		// Token: 0x170012AE RID: 4782
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x00154A5C File Offset: 0x00152C5C
		public unsafe EventLevel Level
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233755, XrefRangeEnd = 233756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012AF RID: 4783
		// (set) Token: 0x060049A3 RID: 18851 RVA: 0x00154A90 File Offset: 0x00152C90
		public unsafe EventOpcode Opcode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233756, XrefRangeEnd = 233757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x00154AC4 File Offset: 0x00152CC4
		public unsafe EventKeywords Keywords
		{
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceOptions.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x0001B906 File Offset: 0x00019B06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSourceOptions>.NativeClassPtr, ref this));
		}

		// Token: 0x04003B96 RID: 15254
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04003B97 RID: 15255
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x04003B98 RID: 15256
		private static readonly IntPtr NativeFieldInfoPtr_activityOptions;

		// Token: 0x04003B99 RID: 15257
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003B9A RID: 15258
		private static readonly IntPtr NativeFieldInfoPtr_opcode;

		// Token: 0x04003B9B RID: 15259
		private static readonly IntPtr NativeFieldInfoPtr_valuesSet;

		// Token: 0x04003B9C RID: 15260
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0;

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeMethodInfoPtr_set_Opcode_Public_set_Void_EventOpcode_0;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0;

		// Token: 0x04003B9F RID: 15263
		[FieldOffset(0)]
		public EventKeywords keywords;

		// Token: 0x04003BA0 RID: 15264
		[FieldOffset(8)]
		public EventTags tags;

		// Token: 0x04003BA1 RID: 15265
		[FieldOffset(12)]
		public EventActivityOptions activityOptions;

		// Token: 0x04003BA2 RID: 15266
		[FieldOffset(16)]
		public byte level;

		// Token: 0x04003BA3 RID: 15267
		[FieldOffset(17)]
		public byte opcode;

		// Token: 0x04003BA4 RID: 15268
		[FieldOffset(18)]
		public byte valuesSet;
	}
}
