using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E8 RID: 232
	public sealed class UnhandledExceptionHandler : Object
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x0000AF1E File Offset: 0x0000911E
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnhandledExceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr);
			UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, 100664998);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0004F5B8 File Offset: 0x0004D7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496867, XrefRangeEnd = 496886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUECatcher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0000AF57 File Offset: 0x00009157
		public UnhandledExceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0;

		// Token: 0x020007BE RID: 1982
		[ObfuscatedName("UnityEngine.UnhandledExceptionHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002D76 RID: 11638 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr);
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9");
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9__0_0");
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100665000);
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100665001);
			}

			// Token: 0x06002D77 RID: 11639 RVA: 0x0007C274 File Offset: 0x0007A474
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D78 RID: 11640 RVA: 0x0007C2B0 File Offset: 0x0007A4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496858, XrefRangeEnd = 496867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterUECatcher_b__0_0(Object sender, UnhandledExceptionEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D79 RID: 11641 RVA: 0x0001381C File Offset: 0x00011A1C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06002D7A RID: 11642 RVA: 0x0007C304 File Offset: 0x0007A504
			// (set) Token: 0x06002D7B RID: 11643 RVA: 0x00013825 File Offset: 0x00011A25
			public unsafe static UnhandledExceptionHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0007C32C File Offset: 0x0007A52C
			// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00013837 File Offset: 0x00011A37
			public unsafe static UnhandledExceptionEventHandler __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F26 RID: 7974
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F27 RID: 7975
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001F28 RID: 7976
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F29 RID: 7977
			private static readonly IntPtr NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0;
		}

		// Token: 0x020007BF RID: 1983
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
