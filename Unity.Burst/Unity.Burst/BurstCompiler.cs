using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst
{
	// Token: 0x02000007 RID: 7
	public static class BurstCompiler : Object
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002A04 File Offset: 0x00000C04
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompiler()
		{
			Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr);
			BurstCompiler.NativeFieldInfoPtr__IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "_IsEnabled");
			BurstCompiler.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "Options");
			BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "DummyMethodInfo");
			BurstCompiler.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663306);
			BurstCompiler.NativeMethodInfoPtr_IsMatchingMethod_Private_Static_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663307);
			BurstCompiler.NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663308);
			BurstCompiler.NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663309);
			BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663310);
			BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663311);
			BurstCompiler.NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663312);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002AFC File Offset: 0x00000CFC
		public unsafe static bool IsEnabled
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 439408, RefRangeEnd = 439419, XrefRangeStart = 439403, XrefRangeEnd = 439408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B2C File Offset: 0x00000D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439419, XrefRangeEnd = 439425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatchingMethod(MethodInfo burstMethod, MethodInfo otherMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(burstMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_IsMatchingMethod_Private_Static_Boolean_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B80 File Offset: 0x00000D80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 439495, RefRangeEnd = 439505, XrefRangeStart = 439425, XrefRangeEnd = 439495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002BB4 File Offset: 0x00000DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439514, RefRangeEnd = 439516, XrefRangeStart = 439505, XrefRangeEnd = 439514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = delegateMethod;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref delegateMethod;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FunctionPointer<T>(intPtr);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C3C File Offset: 0x00000E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439516, XrefRangeEnd = 439522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Compile(Object delegateObj, bool isFunctionPointer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFunctionPointer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C84 File Offset: 0x00000E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 439590, RefRangeEnd = 439593, XrefRangeStart = 439522, XrefRangeEnd = 439590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Compile(Object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, Object managedFallbackDelegateObj = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFunctionPointer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(managedFallbackDelegateObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DummyMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000214D File Offset: 0x0000034D
		public BurstCompiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002156 File Offset: 0x00000356
		public unsafe static bool _IsEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr__IsEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr__IsEnabled, (void*)(&value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002D34 File Offset: 0x00000F34
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002164 File Offset: 0x00000364
		public unsafe static BurstCompilerOptions Options
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr_Options, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompilerOptions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr_Options, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002D5C File Offset: 0x00000F5C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002176 File Offset: 0x00000376
		public unsafe static MethodInfo DummyMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_DummyMethodInfo;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingMethod_Private_Static_Boolean_MethodInfo_MethodInfo_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Object_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0;

		// Token: 0x02000016 RID: 22
		public class StaticTypeReinitAttribute : Attribute
		{
			// Token: 0x06000072 RID: 114 RVA: 0x00004C70 File Offset: 0x00002E70
			// Note: this type is marked as 'beforefieldinit'.
			static StaticTypeReinitAttribute()
			{
				Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "StaticTypeReinitAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr);
				BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr, "reinitType");
				BurstCompiler.StaticTypeReinitAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr, 100663314);
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00004CC4 File Offset: 0x00002EC4
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StaticTypeReinitAttribute(Type toReinit)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(toReinit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.StaticTypeReinitAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000074 RID: 116 RVA: 0x0000242D File Offset: 0x0000062D
			public StaticTypeReinitAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00004D10 File Offset: 0x00002F10
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00002436 File Offset: 0x00000636
			public unsafe Type reinitType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr_reinitType;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x02000017 RID: 23
		public static class BurstCompilerHelper : Object
		{
			// Token: 0x06000077 RID: 119 RVA: 0x00004D40 File Offset: 0x00002F40
			// Note: this type is marked as 'beforefieldinit'.
			static BurstCompilerHelper()
			{
				Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "BurstCompilerHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr);
				BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledImpl");
				BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstGenerated");
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663315);
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663316);
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663317);
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00004DD0 File Offset: 0x00002FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439391, XrefRangeEnd = 439394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsBurstEnabled()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00004E00 File Offset: 0x00003000
			[CallerCount(0)]
			public unsafe static void DiscardedMethod(ref bool value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00004E34 File Offset: 0x00003034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439394, XrefRangeEnd = 439400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsCompiledByBurst(Delegate del)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002455 File Offset: 0x00000655
			public BurstCompilerHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600007C RID: 124 RVA: 0x00004E78 File Offset: 0x00003078
			// (set) Token: 0x0600007D RID: 125 RVA: 0x0000245E File Offset: 0x0000065E
			public unsafe static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00004EA0 File Offset: 0x000030A0
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00002470 File Offset: 0x00000670
			public unsafe static bool IsBurstGenerated
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated, (void*)(&value));
				}
			}

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr_IsBurstEnabledImpl;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeFieldInfoPtr_IsBurstGenerated;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0;

			// Token: 0x02000024 RID: 36
			public sealed class IsBurstEnabledDelegate : MulticastDelegate
			{
				// Token: 0x060000B7 RID: 183 RVA: 0x00005A90 File Offset: 0x00003C90
				// Note: this type is marked as 'beforefieldinit'.
				static IsBurstEnabledDelegate()
				{
					Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledDelegate");
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663319);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663320);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663321);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663322);
				}

				// Token: 0x060000B8 RID: 184 RVA: 0x00005B04 File Offset: 0x00003D04
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsBurstEnabledDelegate(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060000B9 RID: 185 RVA: 0x00005B60 File Offset: 0x00003D60
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 439388, RefRangeEnd = 439391, XrefRangeStart = 439388, XrefRangeEnd = 439388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool Invoke()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060000BA RID: 186 RVA: 0x00005B9C File Offset: 0x00003D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060000BB RID: 187 RVA: 0x00005C00 File Offset: 0x00003E00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060000BC RID: 188 RVA: 0x000025CE File Offset: 0x000007CE
				public IsBurstEnabledDelegate(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060000BD RID: 189 RVA: 0x000025D7 File Offset: 0x000007D7
				public static implicit operator BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate(Func<bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>(A_0);
				}

				// Token: 0x060000BE RID: 190 RVA: 0x000025DF File Offset: 0x000007DF
				public static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate operator +(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_0, BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>();
				}

				// Token: 0x060000BF RID: 191 RVA: 0x000025ED File Offset: 0x000007ED
				public static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate operator -(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_0, BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>();
					}
					return delegate2;
				}

				// Token: 0x04000242 RID: 578
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04000243 RID: 579
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0;

				// Token: 0x04000244 RID: 580
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

				// Token: 0x04000245 RID: 581
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}
		}

		// Token: 0x02000018 RID: 24
		public class FakeDelegate : Object
		{
			// Token: 0x06000080 RID: 128 RVA: 0x00004EBC File Offset: 0x000030BC
			// Note: this type is marked as 'beforefieldinit'.
			static FakeDelegate()
			{
				Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "FakeDelegate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr);
				BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, "<Method>k__BackingField");
				BurstCompiler.FakeDelegate.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, 100663323);
				BurstCompiler.FakeDelegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, 100663324);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00004F24 File Offset: 0x00003124
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FakeDelegate(MethodInfo method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.FakeDelegate.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00004F70 File Offset: 0x00003170
			public unsafe MethodInfo Method
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.FakeDelegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06000083 RID: 131 RVA: 0x0000247E File Offset: 0x0000067E
			public FakeDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00004FB0 File Offset: 0x000031B0
			// (set) Token: 0x06000085 RID: 133 RVA: 0x00002487 File Offset: 0x00000687
			public unsafe MethodInfo _Method_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;
		}

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("Unity.Burst.BurstCompiler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000086 RID: 134 RVA: 0x00004FE0 File Offset: 0x000031E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr);
				BurstCompiler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, "<>9");
				BurstCompiler.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, "<>9__14_0");
				BurstCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, 100663326);
				BurstCompiler.__c.NativeMethodInfoPtr__Compile_b__14_0_Internal_Boolean_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, 100663327);
			}

			// Token: 0x06000087 RID: 135 RVA: 0x0000505C File Offset: 0x0000325C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00005098 File Offset: 0x00003298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439400, XrefRangeEnd = 439403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Compile_b__14_0(Attribute s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.__c.NativeMethodInfoPtr__Compile_b__14_0_Internal_Boolean_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000024A6 File Offset: 0x000006A6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000050E8 File Offset: 0x000032E8
			// (set) Token: 0x0600008B RID: 139 RVA: 0x000024AF File Offset: 0x000006AF
			public unsafe static BurstCompiler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompiler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00005110 File Offset: 0x00003310
			// (set) Token: 0x0600008D RID: 141 RVA: 0x000024C1 File Offset: 0x000006C1
			public unsafe static Func<Attribute, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Attribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__14_0_Internal_Boolean_Attribute_0;
		}

		// Token: 0x0200001A RID: 26
		private sealed class MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>
		{
			// Token: 0x04000229 RID: 553
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstCompiler.NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
