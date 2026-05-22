using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001F3 RID: 499
	public static class DOTweenCYInstruction : global::Il2CppSystem.Object
	{
		// Token: 0x06001990 RID: 6544 RVA: 0x00009F22 File Offset: 0x00008122
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenCYInstruction()
		{
			Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenCYInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00009F47 File Offset: 0x00008147
		public DOTweenCYInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x020002B1 RID: 689
		public class WaitForCompletion : CustomYieldInstruction
		{
			// Token: 0x0600240C RID: 9228 RVA: 0x00099EF4 File Offset: 0x000980F4
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForCompletion()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForCompletion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr);
				DOTweenCYInstruction.WaitForCompletion.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForCompletion.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr, 100667308);
				DOTweenCYInstruction.WaitForCompletion.NativeMethodInfoPtr__ctor_Public_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr, 100667309);
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x0600240D RID: 9229 RVA: 0x00099F5C File Offset: 0x0009815C
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForCompletion.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600240E RID: 9230 RVA: 0x00099FA4 File Offset: 0x000981A4
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaitForCompletion(Tween tween)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForCompletion>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForCompletion.NativeMethodInfoPtr__ctor_Public_Void_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x0000D867 File Offset: 0x0000BA67
			public WaitForCompletion(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06002410 RID: 9232 RVA: 0x00099FF0 File Offset: 0x000981F0
			// (set) Token: 0x06002411 RID: 9233 RVA: 0x0000D870 File Offset: 0x0000BA70
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForCompletion.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForCompletion.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002270 RID: 8816
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04002271 RID: 8817
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x04002272 RID: 8818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_0;
		}

		// Token: 0x020002B2 RID: 690
		public class WaitForRewind : CustomYieldInstruction
		{
			// Token: 0x06002412 RID: 9234 RVA: 0x0009A020 File Offset: 0x00098220
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForRewind()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForRewind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr);
				DOTweenCYInstruction.WaitForRewind.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForRewind.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr, 100667310);
				DOTweenCYInstruction.WaitForRewind.NativeMethodInfoPtr__ctor_Public_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr, 100667311);
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x0009A088 File Offset: 0x00098288
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForRewind.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002414 RID: 9236 RVA: 0x0009A0D0 File Offset: 0x000982D0
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaitForRewind(Tween tween)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForRewind>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForRewind.NativeMethodInfoPtr__ctor_Public_Void_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002415 RID: 9237 RVA: 0x0000D88F File Offset: 0x0000BA8F
			public WaitForRewind(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06002416 RID: 9238 RVA: 0x0009A11C File Offset: 0x0009831C
			// (set) Token: 0x06002417 RID: 9239 RVA: 0x0000D898 File Offset: 0x0000BA98
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForRewind.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForRewind.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002273 RID: 8819
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04002274 RID: 8820
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x04002275 RID: 8821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_0;
		}

		// Token: 0x020002B3 RID: 691
		public class WaitForKill : CustomYieldInstruction
		{
			// Token: 0x06002418 RID: 9240 RVA: 0x0009A14C File Offset: 0x0009834C
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForKill()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForKill");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr);
				DOTweenCYInstruction.WaitForKill.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForKill.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr, 100667312);
				DOTweenCYInstruction.WaitForKill.NativeMethodInfoPtr__ctor_Public_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr, 100667313);
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06002419 RID: 9241 RVA: 0x0009A1B4 File Offset: 0x000983B4
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForKill.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600241A RID: 9242 RVA: 0x0009A1FC File Offset: 0x000983FC
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaitForKill(Tween tween)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForKill>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForKill.NativeMethodInfoPtr__ctor_Public_Void_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600241B RID: 9243 RVA: 0x0000D8B7 File Offset: 0x0000BAB7
			public WaitForKill(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x0600241C RID: 9244 RVA: 0x0009A248 File Offset: 0x00098448
			// (set) Token: 0x0600241D RID: 9245 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForKill.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForKill.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002276 RID: 8822
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04002277 RID: 8823
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x04002278 RID: 8824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_0;
		}

		// Token: 0x020002B4 RID: 692
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			// Token: 0x0600241E RID: 9246 RVA: 0x0009A278 File Offset: 0x00098478
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForElapsedLoops()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForElapsedLoops");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr);
				DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_elapsedLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr, "elapsedLoops");
				DOTweenCYInstruction.WaitForElapsedLoops.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr, 100667314);
				DOTweenCYInstruction.WaitForElapsedLoops.NativeMethodInfoPtr__ctor_Public_Void_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr, 100667315);
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x0600241F RID: 9247 RVA: 0x0009A2F4 File Offset: 0x000984F4
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForElapsedLoops.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002420 RID: 9248 RVA: 0x0009A33C File Offset: 0x0009853C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaitForElapsedLoops(Tween tween, int elapsedLoops)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForElapsedLoops>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForElapsedLoops.NativeMethodInfoPtr__ctor_Public_Void_Tween_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002421 RID: 9249 RVA: 0x0000D8DF File Offset: 0x0000BADF
			public WaitForElapsedLoops(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06002422 RID: 9250 RVA: 0x0009A398 File Offset: 0x00098598
			// (set) Token: 0x06002423 RID: 9251 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06002424 RID: 9252 RVA: 0x0009A3C8 File Offset: 0x000985C8
			// (set) Token: 0x06002425 RID: 9253 RVA: 0x0000D907 File Offset: 0x0000BB07
			public unsafe int elapsedLoops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_elapsedLoops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForElapsedLoops.NativeFieldInfoPtr_elapsedLoops)) = value;
				}
			}

			// Token: 0x04002279 RID: 8825
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400227A RID: 8826
			private static readonly IntPtr NativeFieldInfoPtr_elapsedLoops;

			// Token: 0x0400227B RID: 8827
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x0400227C RID: 8828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_Int32_0;
		}

		// Token: 0x020002B5 RID: 693
		public class WaitForPosition : CustomYieldInstruction
		{
			// Token: 0x06002426 RID: 9254 RVA: 0x0009A3F0 File Offset: 0x000985F0
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForPosition()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForPosition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr);
				DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr, "position");
				DOTweenCYInstruction.WaitForPosition.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr, 100667316);
				DOTweenCYInstruction.WaitForPosition.NativeMethodInfoPtr__ctor_Public_Void_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr, 100667317);
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06002427 RID: 9255 RVA: 0x0009A46C File Offset: 0x0009866C
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForPosition.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002428 RID: 9256 RVA: 0x0009A4B4 File Offset: 0x000986B4
			[CallerCount(0)]
			public unsafe WaitForPosition(Tween tween, float position)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForPosition>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForPosition.NativeMethodInfoPtr__ctor_Public_Void_Tween_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002429 RID: 9257 RVA: 0x0000D922 File Offset: 0x0000BB22
			public WaitForPosition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x0009A510 File Offset: 0x00098710
			// (set) Token: 0x0600242B RID: 9259 RVA: 0x0000D92B File Offset: 0x0000BB2B
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x0009A540 File Offset: 0x00098740
			// (set) Token: 0x0600242D RID: 9261 RVA: 0x0000D94A File Offset: 0x0000BB4A
			public unsafe float position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForPosition.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x0400227D RID: 8829
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400227E RID: 8830
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x0400227F RID: 8831
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x04002280 RID: 8832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_Single_0;
		}

		// Token: 0x020002B6 RID: 694
		public class WaitForStart : CustomYieldInstruction
		{
			// Token: 0x0600242E RID: 9262 RVA: 0x0009A568 File Offset: 0x00098768
			// Note: this type is marked as 'beforefieldinit'.
			static WaitForStart()
			{
				Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenCYInstruction>.NativeClassPtr, "WaitForStart");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr);
				DOTweenCYInstruction.WaitForStart.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr, "t");
				DOTweenCYInstruction.WaitForStart.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr, 100667318);
				DOTweenCYInstruction.WaitForStart.NativeMethodInfoPtr__ctor_Public_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr, 100667319);
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x0600242F RID: 9263 RVA: 0x0009A5D0 File Offset: 0x000987D0
			public unsafe override bool keepWaiting
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DOTweenCYInstruction.WaitForStart.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002430 RID: 9264 RVA: 0x0009A618 File Offset: 0x00098818
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WaitForStart(Tween tween)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenCYInstruction.WaitForStart>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenCYInstruction.WaitForStart.NativeMethodInfoPtr__ctor_Public_Void_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002431 RID: 9265 RVA: 0x0000D965 File Offset: 0x0000BB65
			public WaitForStart(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06002432 RID: 9266 RVA: 0x0009A664 File Offset: 0x00098864
			// (set) Token: 0x06002433 RID: 9267 RVA: 0x0000D96E File Offset: 0x0000BB6E
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForStart.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenCYInstruction.WaitForStart.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002281 RID: 8833
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04002282 RID: 8834
			private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

			// Token: 0x04002283 RID: 8835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tween_0;
		}
	}
}
