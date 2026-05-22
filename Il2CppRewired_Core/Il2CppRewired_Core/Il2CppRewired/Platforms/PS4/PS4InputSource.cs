using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms.Custom;
using Il2CppRewired.Platforms.PS4.Internal;
using Il2CppRewired.Utils.Interfaces;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x02000194 RID: 404
	public sealed class PS4InputSource : CustomInputSource
	{
		// Token: 0x06002957 RID: 10583 RVA: 0x000D0BE4 File Offset: 0x000CEDE4
		// Note: this type is marked as 'beforefieldinit'.
		static PS4InputSource()
		{
			Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "PS4InputSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr);
			PS4InputSource.NativeFieldInfoPtr_xpQnUYlDhVLIZjACsjDhiwNeqHm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "xpQnUYlDhVLIZjACsjDhiwNeqHm");
			PS4InputSource.NativeFieldInfoPtr_JMgvJaOvaPTdikZdkMMRdCoSiTq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "JMgvJaOvaPTdikZdkMMRdCoSiTq");
			PS4InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			PS4InputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673312);
			PS4InputSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673313);
			PS4InputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673314);
			PS4InputSource.NativeMethodInfoPtr_IateqDjwsujHrNSyfDrCfenIETxG_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673315);
			PS4InputSource.NativeMethodInfoPtr_blzLdVuZlANbAjvNiIUPdrbFDZQ_Private_Void_jEsHPwguquukeSloGwZdTqBDKCvy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673316);
			PS4InputSource.NativeMethodInfoPtr_CeCHmreypzsVRpzDWqntPizTIcD_Private_Void_LyCIqIDJtLWQqrFEYaPMYMsNSIg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673317);
			PS4InputSource.NativeMethodInfoPtr_unoftiJynIvetAKWLOxenhKkgsMo_Private_Void_ywVdASfjlklzKsacfANGWLSTWqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673318);
			PS4InputSource.NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673319);
			PS4InputSource.NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673320);
			PS4InputSource.NativeMethodInfoPtr_jFLXvnAueOKtTZVkVEHsqlEaOZV_Private_Virtual_Final_New_Boolean_ControllerType_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673321);
			PS4InputSource.NativeMethodInfoPtr_luZcdpKgRNylKxKpckIHKdPIhAyp_Private_Virtual_Final_New_Void_ControllerType_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673322);
			PS4InputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673323);
			PS4InputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, 100673324);
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000D0D54 File Offset: 0x000CEF54
		public unsafe override bool isReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000D0D90 File Offset: 0x000CEF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310727, XrefRangeEnd = 310758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4InputSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000D0DCC File Offset: 0x000CEFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310758, XrefRangeEnd = 310771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000D0E00 File Offset: 0x000CF000
		[CallerCount(0)]
		public unsafe static int IateqDjwsujHrNSyfDrCfenIETxG(int A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_IateqDjwsujHrNSyfDrCfenIETxG_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000D0E40 File Offset: 0x000CF040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310771, XrefRangeEnd = 310775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void blzLdVuZlANbAjvNiIUPdrbFDZQ(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_blzLdVuZlANbAjvNiIUPdrbFDZQ_Private_Void_jEsHPwguquukeSloGwZdTqBDKCvy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000D0E80 File Offset: 0x000CF080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310775, XrefRangeEnd = 310777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CeCHmreypzsVRpzDWqntPizTIcD(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_CeCHmreypzsVRpzDWqntPizTIcD_Private_Void_LyCIqIDJtLWQqrFEYaPMYMsNSIg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000D0EC4 File Offset: 0x000CF0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310777, XrefRangeEnd = 310797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unoftiJynIvetAKWLOxenhKkgsMo(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_unoftiJynIvetAKWLOxenhKkgsMo_Private_Void_ywVdASfjlklzKsacfANGWLSTWqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x000D0F04 File Offset: 0x000CF104
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x000D0F40 File Offset: 0x000CF140
		public unsafe bool Rewired.Interfaces.IControllerAssigner.enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000D0F80 File Offset: 0x000CF180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310797, XrefRangeEnd = 310801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool jFLXvnAueOKtTZVkVEHsqlEaOZV(ControllerType A_1, Il2CppRewired.Controller A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_jFLXvnAueOKtTZVkVEHsqlEaOZV_Private_Virtual_Final_New_Boolean_ControllerType_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000D0FDC File Offset: 0x000CF1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310801, XrefRangeEnd = 310824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void luZcdpKgRNylKxKpckIHKdPIhAyp(ControllerType A_1, Il2CppRewired.Controller A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_luZcdpKgRNylKxKpckIHKdPIhAyp_Private_Virtual_Final_New_Void_ControllerType_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000D102C File Offset: 0x000CF22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310824, XrefRangeEnd = 310827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000D1060 File Offset: 0x000CF260
		[CallerCount(0)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0000FBC6 File Offset: 0x0000DDC6
		public PS4InputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000D10A0 File Offset: 0x000CF2A0
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x0000FBCF File Offset: 0x0000DDCF
		public unsafe PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv xpQnUYlDhVLIZjACsjDhiwNeqHm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_xpQnUYlDhVLIZjACsjDhiwNeqHm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_xpQnUYlDhVLIZjACsjDhiwNeqHm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000D10D0 File Offset: 0x000CF2D0
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0000FBEE File Offset: 0x0000DDEE
		public unsafe bool JMgvJaOvaPTdikZdkMMRdCoSiTq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_JMgvJaOvaPTdikZdkMMRdCoSiTq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_JMgvJaOvaPTdikZdkMMRdCoSiTq)) = value;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000D10F8 File Offset: 0x000CF2F8
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0000FC09 File Offset: 0x0000DE09
		public new unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeFieldInfoPtr_xpQnUYlDhVLIZjACsjDhiwNeqHm;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeFieldInfoPtr_JMgvJaOvaPTdikZdkMMRdCoSiTq;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_IateqDjwsujHrNSyfDrCfenIETxG_Private_Static_Int32_Int32_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_blzLdVuZlANbAjvNiIUPdrbFDZQ_Private_Void_jEsHPwguquukeSloGwZdTqBDKCvy_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_CeCHmreypzsVRpzDWqntPizTIcD_Private_Void_LyCIqIDJtLWQqrFEYaPMYMsNSIg_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_unoftiJynIvetAKWLOxenhKkgsMo_Private_Void_ywVdASfjlklzKsacfANGWLSTWqX_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerAssigner_set_enabled_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_jFLXvnAueOKtTZVkVEHsqlEaOZV_Private_Virtual_Final_New_Boolean_ControllerType_Controller_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_luZcdpKgRNylKxKpckIHKdPIhAyp_Private_Virtual_Final_New_Void_ControllerType_Controller_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0200038E RID: 910
		public class SJNCFmguYJrIgdvwOmvYRGhRQWv : global::Il2CppSystem.Object
		{
			// Token: 0x06004B5A RID: 19290 RVA: 0x001585FC File Offset: 0x001567FC
			// Note: this type is marked as 'beforefieldinit'.
			static SJNCFmguYJrIgdvwOmvYRGhRQWv()
			{
				Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "SJNCFmguYJrIgdvwOmvYRGhRQWv");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_KSCWkpyVWLdtNvYeYIToETudjAU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "KSCWkpyVWLdtNvYeYIToETudjAU");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_rgHBGtJAsiCqbHoIMrsGFkLvsyM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "rgHBGtJAsiCqbHoIMrsGFkLvsyM");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_DcCmZVbuWVOMTqNhkZaqhjnpQot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "DcCmZVbuWVOMTqNhkZaqhjnpQot");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BjsaacrOlwtVlQNQfdvqiEuzitq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "BjsaacrOlwtVlQNQfdvqiEuzitq");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_SbeuqPdeobdYUwovXaVegPkSrqGI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "SbeuqPdeobdYUwovXaVegPkSrqGI");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_lvUcTxTCnicQTwEmgazscERBrVQP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "lvUcTxTCnicQTwEmgazscERBrVQP");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BOUJxwvQQGgzqJDxsaDrOEiQtQS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "BOUJxwvQQGgzqJDxsaDrOEiQtQS");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_iufLOKIqWQMYJBlkDgxvztaAYJO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "iufLOKIqWQMYJBlkDgxvztaAYJO");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_PqkEQMffTCwFVSRPeHtMfDcKSUpG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "PqkEQMffTCwFVSRPeHtMfDcKSUpG");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wtpGjNUUKQMTbJYnKRtkygZZOLc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "wtpGjNUUKQMTbJYnKRtkygZZOLc");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_RnmKumBJHxKLgvSJFAeuRWzjDeR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "RnmKumBJHxKLgvSJFAeuRWzjDeR");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wKcZOWlJxIgdtiurSWWQzzXZzgh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "wKcZOWlJxIgdtiurSWWQzzXZzgh");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_tEACgqhfGVMOGsZGsKbKkSwPwskK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "tEACgqhfGVMOGsZGsKbKkSwPwskK");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "YtejDiqaLAxxRnmscggDavQFcLz");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "ikzytTXFFDqNPkVCCmeRclgjukz");
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_add_ControllerConnectedEvent_Public_add_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673325);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_remove_ControllerConnectedEvent_Public_rem_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673326);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_add_ControllerDisconnectedEvent_Public_add_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673327);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_remove_ControllerDisconnectedEvent_Public_rem_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673328);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673329);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673330);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_fIcYjGAHHlOJZsPwPUHtOtiGYlO_Private_Void_Int32_oFbHtkCkdPtcpMRsLmBXClWAVeJC_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673331);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_QRCLiZTfzHeVQjbCBSIuFyshpmS_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673332);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673333);
				PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, 100673334);
			}

			// Token: 0x06004B5B RID: 19291 RVA: 0x0015881C File Offset: 0x00156A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309785, XrefRangeEnd = 309788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void add_ControllerConnectedEvent(Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_add_ControllerConnectedEvent_Public_add_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B5C RID: 19292 RVA: 0x00158860 File Offset: 0x00156A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309788, XrefRangeEnd = 309791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void remove_ControllerConnectedEvent(Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_remove_ControllerConnectedEvent_Public_rem_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B5D RID: 19293 RVA: 0x001588A4 File Offset: 0x00156AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309791, XrefRangeEnd = 309794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void add_ControllerDisconnectedEvent(Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_add_ControllerDisconnectedEvent_Public_add_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B5E RID: 19294 RVA: 0x001588E8 File Offset: 0x00156AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309794, XrefRangeEnd = 309797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void remove_ControllerDisconnectedEvent(Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_remove_ControllerDisconnectedEvent_Public_rem_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B5F RID: 19295 RVA: 0x0015892C File Offset: 0x00156B2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 309862, RefRangeEnd = 309863, XrefRangeStart = 309797, XrefRangeEnd = 309862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SJNCFmguYJrIgdvwOmvYRGhRQWv(int maxPlayers)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref maxPlayers;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B60 RID: 19296 RVA: 0x00158974 File Offset: 0x00156B74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 309917, RefRangeEnd = 309918, XrefRangeStart = 309863, XrefRangeEnd = 309917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B61 RID: 19297 RVA: 0x001589A8 File Offset: 0x00156BA8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 309927, RefRangeEnd = 309930, XrefRangeStart = 309918, XrefRangeEnd = 309927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void fIcYjGAHHlOJZsPwPUHtOtiGYlO(int A_1, PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC A_2, int A_3, bool A_4, string A_5)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(A_5);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_fIcYjGAHHlOJZsPwPUHtOtiGYlO_Private_Void_Int32_oFbHtkCkdPtcpMRsLmBXClWAVeJC_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B62 RID: 19298 RVA: 0x00158A28 File Offset: 0x00156C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309930, XrefRangeEnd = 309933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC QRCLiZTfzHeVQjbCBSIuFyshpmS()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_QRCLiZTfzHeVQjbCBSIuFyshpmS_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>(intPtr3) : null;
			}

			// Token: 0x06004B63 RID: 19299 RVA: 0x00158A5C File Offset: 0x00156C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309933, XrefRangeEnd = 309936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC OUjQkTqHdKDKTdWxkgBYSsdbWWhi()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>(intPtr3) : null;
			}

			// Token: 0x06004B64 RID: 19300 RVA: 0x00158A90 File Offset: 0x00156C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309936, XrefRangeEnd = 309939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC lCXemqrZsgUhCfTWmorHVGADRQm()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>(intPtr3) : null;
			}

			// Token: 0x06004B65 RID: 19301 RVA: 0x0001BBB3 File Offset: 0x00019DB3
			public SJNCFmguYJrIgdvwOmvYRGhRQWv(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700179A RID: 6042
			// (get) Token: 0x06004B66 RID: 19302 RVA: 0x00158AC4 File Offset: 0x00156CC4
			// (set) Token: 0x06004B67 RID: 19303 RVA: 0x0001BBBC File Offset: 0x00019DBC
			public unsafe int KSCWkpyVWLdtNvYeYIToETudjAU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_KSCWkpyVWLdtNvYeYIToETudjAU);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_KSCWkpyVWLdtNvYeYIToETudjAU)) = value;
				}
			}

			// Token: 0x1700179B RID: 6043
			// (get) Token: 0x06004B68 RID: 19304 RVA: 0x00158AEC File Offset: 0x00156CEC
			// (set) Token: 0x06004B69 RID: 19305 RVA: 0x0001BBD7 File Offset: 0x00019DD7
			public unsafe Il2CppStructArray<int> rgHBGtJAsiCqbHoIMrsGFkLvsyM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_rgHBGtJAsiCqbHoIMrsGFkLvsyM);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_rgHBGtJAsiCqbHoIMrsGFkLvsyM), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179C RID: 6044
			// (get) Token: 0x06004B6A RID: 19306 RVA: 0x00158B1C File Offset: 0x00156D1C
			// (set) Token: 0x06004B6B RID: 19307 RVA: 0x0001BBF6 File Offset: 0x00019DF6
			public unsafe Il2CppStructArray<int> DcCmZVbuWVOMTqNhkZaqhjnpQot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_DcCmZVbuWVOMTqNhkZaqhjnpQot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_DcCmZVbuWVOMTqNhkZaqhjnpQot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179D RID: 6045
			// (get) Token: 0x06004B6C RID: 19308 RVA: 0x00158B4C File Offset: 0x00156D4C
			// (set) Token: 0x06004B6D RID: 19309 RVA: 0x0001BC15 File Offset: 0x00019E15
			public unsafe Il2CppStructArray<int> BjsaacrOlwtVlQNQfdvqiEuzitq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BjsaacrOlwtVlQNQfdvqiEuzitq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BjsaacrOlwtVlQNQfdvqiEuzitq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179E RID: 6046
			// (get) Token: 0x06004B6E RID: 19310 RVA: 0x00158B7C File Offset: 0x00156D7C
			// (set) Token: 0x06004B6F RID: 19311 RVA: 0x0001BC34 File Offset: 0x00019E34
			public unsafe IExternalTools SbeuqPdeobdYUwovXaVegPkSrqGI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_SbeuqPdeobdYUwovXaVegPkSrqGI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExternalTools>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_SbeuqPdeobdYUwovXaVegPkSrqGI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179F RID: 6047
			// (get) Token: 0x06004B70 RID: 19312 RVA: 0x00158BAC File Offset: 0x00156DAC
			// (set) Token: 0x06004B71 RID: 19313 RVA: 0x0001BC53 File Offset: 0x00019E53
			public unsafe Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> lvUcTxTCnicQTwEmgazscERBrVQP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_lvUcTxTCnicQTwEmgazscERBrVQP);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_lvUcTxTCnicQTwEmgazscERBrVQP), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A0 RID: 6048
			// (get) Token: 0x06004B72 RID: 19314 RVA: 0x00158BDC File Offset: 0x00156DDC
			// (set) Token: 0x06004B73 RID: 19315 RVA: 0x0001BC72 File Offset: 0x00019E72
			public unsafe Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> BOUJxwvQQGgzqJDxsaDrOEiQtQS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BOUJxwvQQGgzqJDxsaDrOEiQtQS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_BOUJxwvQQGgzqJDxsaDrOEiQtQS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A1 RID: 6049
			// (get) Token: 0x06004B74 RID: 19316 RVA: 0x00158C0C File Offset: 0x00156E0C
			// (set) Token: 0x06004B75 RID: 19317 RVA: 0x0001BC91 File Offset: 0x00019E91
			public unsafe Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> iufLOKIqWQMYJBlkDgxvztaAYJO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_iufLOKIqWQMYJBlkDgxvztaAYJO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_iufLOKIqWQMYJBlkDgxvztaAYJO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A2 RID: 6050
			// (get) Token: 0x06004B76 RID: 19318 RVA: 0x00158C3C File Offset: 0x00156E3C
			// (set) Token: 0x06004B77 RID: 19319 RVA: 0x0001BCB0 File Offset: 0x00019EB0
			public unsafe List<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy> PqkEQMffTCwFVSRPeHtMfDcKSUpG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_PqkEQMffTCwFVSRPeHtMfDcKSUpG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_PqkEQMffTCwFVSRPeHtMfDcKSUpG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A3 RID: 6051
			// (get) Token: 0x06004B78 RID: 19320 RVA: 0x00158C6C File Offset: 0x00156E6C
			// (set) Token: 0x06004B79 RID: 19321 RVA: 0x0001BCCF File Offset: 0x00019ECF
			public unsafe List<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX> wtpGjNUUKQMTbJYnKRtkygZZOLc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wtpGjNUUKQMTbJYnKRtkygZZOLc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wtpGjNUUKQMTbJYnKRtkygZZOLc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A4 RID: 6052
			// (get) Token: 0x06004B7A RID: 19322 RVA: 0x00158C9C File Offset: 0x00156E9C
			// (set) Token: 0x06004B7B RID: 19323 RVA: 0x0001BCEE File Offset: 0x00019EEE
			public unsafe Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy> RnmKumBJHxKLgvSJFAeuRWzjDeR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_RnmKumBJHxKLgvSJFAeuRWzjDeR);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_RnmKumBJHxKLgvSJFAeuRWzjDeR), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A5 RID: 6053
			// (get) Token: 0x06004B7C RID: 19324 RVA: 0x00158CCC File Offset: 0x00156ECC
			// (set) Token: 0x06004B7D RID: 19325 RVA: 0x0001BD0D File Offset: 0x00019F0D
			public unsafe Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX> wKcZOWlJxIgdtiurSWWQzzXZzgh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wKcZOWlJxIgdtiurSWWQzzXZzgh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_wKcZOWlJxIgdtiurSWWQzzXZzgh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A6 RID: 6054
			// (get) Token: 0x06004B7E RID: 19326 RVA: 0x00158CFC File Offset: 0x00156EFC
			// (set) Token: 0x06004B7F RID: 19327 RVA: 0x0001BD2C File Offset: 0x00019F2C
			public unsafe static Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> tEACgqhfGVMOGsZGsKbKkSwPwskK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_tEACgqhfGVMOGsZGsKbKkSwPwskK, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_tEACgqhfGVMOGsZGsKbKkSwPwskK, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A7 RID: 6055
			// (get) Token: 0x06004B80 RID: 19328 RVA: 0x00158D24 File Offset: 0x00156F24
			// (set) Token: 0x06004B81 RID: 19329 RVA: 0x0001BD3E File Offset: 0x00019F3E
			public unsafe static Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> YtejDiqaLAxxRnmscggDavQFcLz
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017A8 RID: 6056
			// (get) Token: 0x06004B82 RID: 19330 RVA: 0x00158D4C File Offset: 0x00156F4C
			// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0001BD50 File Offset: 0x00019F50
			public unsafe static Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC> ikzytTXFFDqNPkVCCmeRclgjukz
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CF1 RID: 15601
			private static readonly IntPtr NativeFieldInfoPtr_KSCWkpyVWLdtNvYeYIToETudjAU;

			// Token: 0x04003CF2 RID: 15602
			private static readonly IntPtr NativeFieldInfoPtr_rgHBGtJAsiCqbHoIMrsGFkLvsyM;

			// Token: 0x04003CF3 RID: 15603
			private static readonly IntPtr NativeFieldInfoPtr_DcCmZVbuWVOMTqNhkZaqhjnpQot;

			// Token: 0x04003CF4 RID: 15604
			private static readonly IntPtr NativeFieldInfoPtr_BjsaacrOlwtVlQNQfdvqiEuzitq;

			// Token: 0x04003CF5 RID: 15605
			private static readonly IntPtr NativeFieldInfoPtr_SbeuqPdeobdYUwovXaVegPkSrqGI;

			// Token: 0x04003CF6 RID: 15606
			private static readonly IntPtr NativeFieldInfoPtr_lvUcTxTCnicQTwEmgazscERBrVQP;

			// Token: 0x04003CF7 RID: 15607
			private static readonly IntPtr NativeFieldInfoPtr_BOUJxwvQQGgzqJDxsaDrOEiQtQS;

			// Token: 0x04003CF8 RID: 15608
			private static readonly IntPtr NativeFieldInfoPtr_iufLOKIqWQMYJBlkDgxvztaAYJO;

			// Token: 0x04003CF9 RID: 15609
			private static readonly IntPtr NativeFieldInfoPtr_PqkEQMffTCwFVSRPeHtMfDcKSUpG;

			// Token: 0x04003CFA RID: 15610
			private static readonly IntPtr NativeFieldInfoPtr_wtpGjNUUKQMTbJYnKRtkygZZOLc;

			// Token: 0x04003CFB RID: 15611
			private static readonly IntPtr NativeFieldInfoPtr_RnmKumBJHxKLgvSJFAeuRWzjDeR;

			// Token: 0x04003CFC RID: 15612
			private static readonly IntPtr NativeFieldInfoPtr_wKcZOWlJxIgdtiurSWWQzzXZzgh;

			// Token: 0x04003CFD RID: 15613
			private static readonly IntPtr NativeFieldInfoPtr_tEACgqhfGVMOGsZGsKbKkSwPwskK;

			// Token: 0x04003CFE RID: 15614
			private static readonly IntPtr NativeFieldInfoPtr_YtejDiqaLAxxRnmscggDavQFcLz;

			// Token: 0x04003CFF RID: 15615
			private static readonly IntPtr NativeFieldInfoPtr_ikzytTXFFDqNPkVCCmeRclgjukz;

			// Token: 0x04003D00 RID: 15616
			private static readonly IntPtr NativeMethodInfoPtr_add_ControllerConnectedEvent_Public_add_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0;

			// Token: 0x04003D01 RID: 15617
			private static readonly IntPtr NativeMethodInfoPtr_remove_ControllerConnectedEvent_Public_rem_Void_Action_1_jEsHPwguquukeSloGwZdTqBDKCvy_0;

			// Token: 0x04003D02 RID: 15618
			private static readonly IntPtr NativeMethodInfoPtr_add_ControllerDisconnectedEvent_Public_add_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0;

			// Token: 0x04003D03 RID: 15619
			private static readonly IntPtr NativeMethodInfoPtr_remove_ControllerDisconnectedEvent_Public_rem_Void_Action_1_ywVdASfjlklzKsacfANGWLSTWqX_0;

			// Token: 0x04003D04 RID: 15620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D05 RID: 15621
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Void_0;

			// Token: 0x04003D06 RID: 15622
			private static readonly IntPtr NativeMethodInfoPtr_fIcYjGAHHlOJZsPwPUHtOtiGYlO_Private_Void_Int32_oFbHtkCkdPtcpMRsLmBXClWAVeJC_Int32_Boolean_String_0;

			// Token: 0x04003D07 RID: 15623
			private static readonly IntPtr NativeMethodInfoPtr_QRCLiZTfzHeVQjbCBSIuFyshpmS_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0;

			// Token: 0x04003D08 RID: 15624
			private static readonly IntPtr NativeMethodInfoPtr_OUjQkTqHdKDKTdWxkgBYSsdbWWhi_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0;

			// Token: 0x04003D09 RID: 15625
			private static readonly IntPtr NativeMethodInfoPtr_lCXemqrZsgUhCfTWmorHVGADRQm_Private_Static_oFbHtkCkdPtcpMRsLmBXClWAVeJC_0;

			// Token: 0x02000590 RID: 1424
			[StructLayout(2)]
			public struct jEsHPwguquukeSloGwZdTqBDKCvy
			{
				// Token: 0x06005F5C RID: 24412 RVA: 0x001A7B10 File Offset: 0x001A5D10
				// Note: this type is marked as 'beforefieldinit'.
				static jEsHPwguquukeSloGwZdTqBDKCvy()
				{
					Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "jEsHPwguquukeSloGwZdTqBDKCvy");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr);
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeFieldInfoPtr_FOkDEjrANFKEPRPasmuYiVyyHNA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, "FOkDEjrANFKEPRPasmuYiVyyHNA");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, "dJjqfJxgvcqMZlxTWfvSSGmwpLI");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, "UFSRfppVOhTXdHOiTCstRnttMvV");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, "KscBQYsUNIFKkCLUVpkuogOHnq");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_BaseControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, 100673335);
				}

				// Token: 0x06005F5D RID: 24413 RVA: 0x001A7BA0 File Offset: 0x001A5DA0
				[CallerCount(0)]
				public unsafe jEsHPwguquukeSloGwZdTqBDKCvy(int playerId, int handle, int deviceClass, PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType baseControllerType)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref playerId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceClass;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseControllerType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_BaseControllerType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005F5E RID: 24414 RVA: 0x000234D8 File Offset: 0x000216D8
				public global::Il2CppSystem.Object BoxIl2CppObject()
				{
					return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.jEsHPwguquukeSloGwZdTqBDKCvy>.NativeClassPtr, ref this));
				}

				// Token: 0x04004E20 RID: 20000
				private static readonly IntPtr NativeFieldInfoPtr_FOkDEjrANFKEPRPasmuYiVyyHNA;

				// Token: 0x04004E21 RID: 20001
				private static readonly IntPtr NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI;

				// Token: 0x04004E22 RID: 20002
				private static readonly IntPtr NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV;

				// Token: 0x04004E23 RID: 20003
				private static readonly IntPtr NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq;

				// Token: 0x04004E24 RID: 20004
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_BaseControllerType_0;

				// Token: 0x04004E25 RID: 20005
				[FieldOffset(0)]
				public int FOkDEjrANFKEPRPasmuYiVyyHNA;

				// Token: 0x04004E26 RID: 20006
				[FieldOffset(4)]
				public int dJjqfJxgvcqMZlxTWfvSSGmwpLI;

				// Token: 0x04004E27 RID: 20007
				[FieldOffset(8)]
				public int UFSRfppVOhTXdHOiTCstRnttMvV;

				// Token: 0x04004E28 RID: 20008
				[FieldOffset(12)]
				public PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType KscBQYsUNIFKkCLUVpkuogOHnq;
			}

			// Token: 0x02000591 RID: 1425
			[StructLayout(2)]
			public struct ywVdASfjlklzKsacfANGWLSTWqX
			{
				// Token: 0x06005F5F RID: 24415 RVA: 0x001A7BFC File Offset: 0x001A5DFC
				// Note: this type is marked as 'beforefieldinit'.
				static ywVdASfjlklzKsacfANGWLSTWqX()
				{
					Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "ywVdASfjlklzKsacfANGWLSTWqX");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr);
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX.NativeFieldInfoPtr_FOkDEjrANFKEPRPasmuYiVyyHNA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr, "FOkDEjrANFKEPRPasmuYiVyyHNA");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX.NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr, "dJjqfJxgvcqMZlxTWfvSSGmwpLI");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX.NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr, "KscBQYsUNIFKkCLUVpkuogOHnq");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_BaseControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr, 100673336);
				}

				// Token: 0x06005F60 RID: 24416 RVA: 0x001A7C78 File Offset: 0x001A5E78
				[CallerCount(0)]
				public unsafe ywVdASfjlklzKsacfANGWLSTWqX(int playerId, int handle, PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType baseControllerType)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref playerId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseControllerType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_BaseControllerType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005F61 RID: 24417 RVA: 0x000234EA File Offset: 0x000216EA
				public global::Il2CppSystem.Object BoxIl2CppObject()
				{
					return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ywVdASfjlklzKsacfANGWLSTWqX>.NativeClassPtr, ref this));
				}

				// Token: 0x04004E29 RID: 20009
				private static readonly IntPtr NativeFieldInfoPtr_FOkDEjrANFKEPRPasmuYiVyyHNA;

				// Token: 0x04004E2A RID: 20010
				private static readonly IntPtr NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI;

				// Token: 0x04004E2B RID: 20011
				private static readonly IntPtr NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq;

				// Token: 0x04004E2C RID: 20012
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_BaseControllerType_0;

				// Token: 0x04004E2D RID: 20013
				[FieldOffset(0)]
				public int FOkDEjrANFKEPRPasmuYiVyyHNA;

				// Token: 0x04004E2E RID: 20014
				[FieldOffset(4)]
				public int dJjqfJxgvcqMZlxTWfvSSGmwpLI;

				// Token: 0x04004E2F RID: 20015
				[FieldOffset(8)]
				public PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType KscBQYsUNIFKkCLUVpkuogOHnq;
			}

			// Token: 0x02000592 RID: 1426
			public class oFbHtkCkdPtcpMRsLmBXClWAVeJC : global::Il2CppSystem.Object
			{
				// Token: 0x06005F62 RID: 24418 RVA: 0x001A7CC8 File Offset: 0x001A5EC8
				// Note: this type is marked as 'beforefieldinit'.
				static oFbHtkCkdPtcpMRsLmBXClWAVeJC()
				{
					Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv>.NativeClassPtr, "oFbHtkCkdPtcpMRsLmBXClWAVeJC");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr);
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, "KscBQYsUNIFKkCLUVpkuogOHnq");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UibwswQzUwqZtlCSZSroePsFzTV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, "UibwswQzUwqZtlCSZSroePsFzTV");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, "dJjqfJxgvcqMZlxTWfvSSGmwpLI");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, "UFSRfppVOhTXdHOiTCstRnttMvV");
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr__ctor_Public_Void_BaseControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, 100673337);
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr_hVdDvcTJGnPEyfpWVnwOcXaYahg_Public_ChangeType_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, 100673338);
					PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr, 100673339);
				}

				// Token: 0x06005F63 RID: 24419 RVA: 0x001A7D80 File Offset: 0x001A5F80
				[CallerCount(0)]
				public unsafe oFbHtkCkdPtcpMRsLmBXClWAVeJC(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType baseControllerType)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref baseControllerType;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr__ctor_Public_Void_BaseControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005F64 RID: 24420 RVA: 0x001A7DC8 File Offset: 0x001A5FC8
				[CallerCount(0)]
				public unsafe PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.ChangeType hVdDvcTJGnPEyfpWVnwOcXaYahg(bool A_1, int A_2, int A_3)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref A_1;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr_hVdDvcTJGnPEyfpWVnwOcXaYahg_Public_ChangeType_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06005F65 RID: 24421 RVA: 0x001A7E30 File Offset: 0x001A6030
				[CallerCount(0)]
				public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005F66 RID: 24422 RVA: 0x000234FC File Offset: 0x000216FC
				public oFbHtkCkdPtcpMRsLmBXClWAVeJC(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001D02 RID: 7426
				// (get) Token: 0x06005F67 RID: 24423 RVA: 0x001A7E64 File Offset: 0x001A6064
				// (set) Token: 0x06005F68 RID: 24424 RVA: 0x00023505 File Offset: 0x00021705
				public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType KscBQYsUNIFKkCLUVpkuogOHnq
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq)) = value;
					}
				}

				// Token: 0x17001D03 RID: 7427
				// (get) Token: 0x06005F69 RID: 24425 RVA: 0x001A7E8C File Offset: 0x001A608C
				// (set) Token: 0x06005F6A RID: 24426 RVA: 0x00023520 File Offset: 0x00021720
				public unsafe bool UibwswQzUwqZtlCSZSroePsFzTV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UibwswQzUwqZtlCSZSroePsFzTV);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UibwswQzUwqZtlCSZSroePsFzTV)) = value;
					}
				}

				// Token: 0x17001D04 RID: 7428
				// (get) Token: 0x06005F6B RID: 24427 RVA: 0x001A7EB4 File Offset: 0x001A60B4
				// (set) Token: 0x06005F6C RID: 24428 RVA: 0x0002353B File Offset: 0x0002173B
				public unsafe int dJjqfJxgvcqMZlxTWfvSSGmwpLI
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI)) = value;
					}
				}

				// Token: 0x17001D05 RID: 7429
				// (get) Token: 0x06005F6D RID: 24429 RVA: 0x001A7EDC File Offset: 0x001A60DC
				// (set) Token: 0x06005F6E RID: 24430 RVA: 0x00023556 File Offset: 0x00021756
				public unsafe int UFSRfppVOhTXdHOiTCstRnttMvV
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SJNCFmguYJrIgdvwOmvYRGhRQWv.oFbHtkCkdPtcpMRsLmBXClWAVeJC.NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV)) = value;
					}
				}

				// Token: 0x04004E30 RID: 20016
				private static readonly IntPtr NativeFieldInfoPtr_KscBQYsUNIFKkCLUVpkuogOHnq;

				// Token: 0x04004E31 RID: 20017
				private static readonly IntPtr NativeFieldInfoPtr_UibwswQzUwqZtlCSZSroePsFzTV;

				// Token: 0x04004E32 RID: 20018
				private static readonly IntPtr NativeFieldInfoPtr_dJjqfJxgvcqMZlxTWfvSSGmwpLI;

				// Token: 0x04004E33 RID: 20019
				private static readonly IntPtr NativeFieldInfoPtr_UFSRfppVOhTXdHOiTCstRnttMvV;

				// Token: 0x04004E34 RID: 20020
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseControllerType_0;

				// Token: 0x04004E35 RID: 20021
				private static readonly IntPtr NativeMethodInfoPtr_hVdDvcTJGnPEyfpWVnwOcXaYahg_Public_ChangeType_Boolean_Int32_Int32_0;

				// Token: 0x04004E36 RID: 20022
				private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0;
			}

			// Token: 0x02000593 RID: 1427
			[OriginalName("Rewired_Core.dll", "", "ChangeType")]
			[Flags]
			public enum ChangeType
			{
				// Token: 0x04004E38 RID: 20024
				None = 0,
				// Token: 0x04004E39 RID: 20025
				Connected = 1,
				// Token: 0x04004E3A RID: 20026
				Disconnected = 2,
				// Token: 0x04004E3B RID: 20027
				IdentityChanged = 4
			}
		}

		// Token: 0x0200038F RID: 911
		public class LyCIqIDJtLWQqrFEYaPMYMsNSIg : CustomInputSource.Joystick
		{
			// Token: 0x06004B84 RID: 19332 RVA: 0x00158D74 File Offset: 0x00156F74
			// Note: this type is marked as 'beforefieldinit'.
			static LyCIqIDJtLWQqrFEYaPMYMsNSIg()
			{
				Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "LyCIqIDJtLWQqrFEYaPMYMsNSIg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_FFRIJQiRpcjmvyHmvccRmfqGnYSL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "FFRIJQiRpcjmvyHmvccRmfqGnYSL");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "HFDLhMjPFtSioLkrcDMAnXTYLIS");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tmaZQesVbebeMFeNJRRBihbXdrY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "tmaZQesVbebeMFeNJRRBihbXdrY");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qRwyKkFordpovHnVqZQlchaIjAtD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "qRwyKkFordpovHnVqZQlchaIjAtD");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_frUicbyQRnhQVJOljiuGIowdDCn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "frUicbyQRnhQVJOljiuGIowdDCn");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "cHXgUkbCYeKQEnSQvuoKhZJTsUc");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XJThhTpGwcteqUMXRPwcSWMNevg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "XJThhTpGwcteqUMXRPwcSWMNevg");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qLhoxMbZgcTrbKiTspiqoqIFplx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "qLhoxMbZgcTrbKiTspiqoqIFplx");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_nsrnORqQJOUaTIvFXuqOObaIeHoa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "nsrnORqQJOUaTIvFXuqOObaIeHoa");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_UlBhmBCQiqZlfmzenfjnGElgKgeF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "UlBhmBCQiqZlfmzenfjnGElgKgeF");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_PIjrUXRojQVGqOUbiJTbjBRoCIxG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "PIjrUXRojQVGqOUbiJTbjBRoCIxG");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_BUbFxqLeJQvsaOvHtRiOFbJPqXw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "BUbFxqLeJQvsaOvHtRiOFbJPqXw");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_eZEEUEduIslFKkCagzFeJSxJHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "eZEEUEduIslFKkCagzFeJSxJHud");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_sxZTRZhhUPxfeNxwcLngQiLybfU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "sxZTRZhhUPxfeNxwcLngQiLybfU");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_EIELmfoRApIkoEMCvByrAykynYE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "EIELmfoRApIkoEMCvByrAykynYE");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XFSjlibMPasPvkhIUNgsNOpzFPj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "XFSjlibMPasPvkhIUNgsNOpzFPj");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_bwxgYexINwapNhjDthjEmZxvRBrD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "bwxgYexINwapNhjDthjEmZxvRBrD");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tOqhJOgvYEMiAcbyQfHiKOMXADbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "tOqhJOgvYEMiAcbyQfHiKOMXADbo");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_JwlbaJVgTfQEUccsRAvXaXMlBVhp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "JwlbaJVgTfQEUccsRAvXaXMlBVhp");
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_NextSystemId_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673340);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_LyCIqIDJtLWQqrFEYaPMYMsNSIg_ControllerType_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673341);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_user_Protected_get_LoggedInUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673342);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673343);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673344);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673345);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_baseControllerType_Public_get_BaseControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673346);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_IsConnectedNow_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673347);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_BaseControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673348);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673349);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ltrLYnhSCHjNmOJneCQmUuVLGKg_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673350);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_sioUuDkIQkzjpUoTuKaSYHZarts_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673351);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_gaBUEUqatjrgPCMWjsWkDtcyfkH_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673352);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_cxsItqtnnCKOIWotbScepGOOxgS_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673353);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_cJFCvlZPbtJRhImbVbbcbCcBxjnV_Public_Virtual_Final_New_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673354);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DhkgVIURIDfREFmBfpWljnxOSJnl_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673355);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ajLaezphWudFNBGiotEROuYayZdF_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673356);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673357);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673358);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673359);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673360);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetMotionSensorState_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673361);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673362);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673363);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673364);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastAcceleration_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673365);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673366);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastGyro_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673367);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastGyroRaw_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673368);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastOrientation_Public_Virtual_Final_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673369);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastOrientationRaw_Public_Virtual_Final_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673370);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673371);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ResetLight_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673372);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673373);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_hPdBrvEfhFajovIsXuYWCWotLqj_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673374);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_tbPWEBktbgCkRItSMDZSKpOXHlG_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673375);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Public_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673376);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Public_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673377);
				PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_WrBNencOXMZfhInCDSFUXHoEqMG_Public_Static_Boolean_Int32_byref_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, 100673378);
			}

			// Token: 0x170017BD RID: 6077
			// (get) Token: 0x06004B85 RID: 19333 RVA: 0x0015923C File Offset: 0x0015743C
			public unsafe static int RFDwabmAuCfGTwBtGWGyjJhxeKP
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309939, XrefRangeEnd = 309943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_NextSystemId_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x0015926C File Offset: 0x0015746C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 309949, RefRangeEnd = 309950, XrefRangeStart = 309943, XrefRangeEnd = 309949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg dSubCKSikOaufAaxCnPWeKqiPeHk(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType A_0, int A_1, int A_2, int A_3)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_LyCIqIDJtLWQqrFEYaPMYMsNSIg_ControllerType_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>(intPtr3) : null;
			}

			// Token: 0x170017BE RID: 6078
			// (get) Token: 0x06004B87 RID: 19335 RVA: 0x001592D8 File Offset: 0x001574D8
			public unsafe LoggedInUser QYMHSVsphtRITvBjmyNWCbvSGtL
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 309957, RefRangeEnd = 309963, XrefRangeStart = 309950, XrefRangeEnd = 309957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_user_Protected_get_LoggedInUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoggedInUser>(intPtr3) : null;
				}
			}

			// Token: 0x170017BF RID: 6079
			// (get) Token: 0x06004B88 RID: 19336 RVA: 0x00159318 File Offset: 0x00157518
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType crFuiBooxxTCRjzsdbdXzBFLXPj
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_type_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017C0 RID: 6080
			// (get) Token: 0x06004B89 RID: 19337 RVA: 0x00159354 File Offset: 0x00157554
			public unsafe int FOkDEjrANFKEPRPasmuYiVyyHNA
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017C1 RID: 6081
			// (get) Token: 0x06004B8A RID: 19338 RVA: 0x00159390 File Offset: 0x00157590
			public unsafe int dJjqfJxgvcqMZlxTWfvSSGmwpLI
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017C2 RID: 6082
			// (get) Token: 0x06004B8B RID: 19339 RVA: 0x001593CC File Offset: 0x001575CC
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType KscBQYsUNIFKkCLUVpkuogOHnq
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_baseControllerType_Public_get_BaseControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017C3 RID: 6083
			// (get) Token: 0x06004B8C RID: 19340 RVA: 0x00159408 File Offset: 0x00157608
			public unsafe bool oNigTAGgqcxuLkUTpvtoGuESrUC
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309963, XrefRangeEnd = 309967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_IsConnectedNow_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B8D RID: 19341 RVA: 0x00159444 File Offset: 0x00157644
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310266, RefRangeEnd = 310269, XrefRangeStart = 309967, XrefRangeEnd = 310266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LyCIqIDJtLWQqrFEYaPMYMsNSIg(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType type, PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType baseControllerType, string name, int playerId, int unityJoystickId, int handle, PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl capabilities)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseControllerType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capabilities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_BaseControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B8E RID: 19342 RVA: 0x001594E8 File Offset: 0x001576E8
			[CallerCount(0)]
			public unsafe override void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B8F RID: 19343 RVA: 0x00159524 File Offset: 0x00157724
			[CallerCount(0)]
			public unsafe virtual int ltrLYnhSCHjNmOJneCQmUuVLGKg()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ltrLYnhSCHjNmOJneCQmUuVLGKg_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B90 RID: 19344 RVA: 0x00159560 File Offset: 0x00157760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310269, XrefRangeEnd = 310270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int sioUuDkIQkzjpUoTuKaSYHZarts()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_sioUuDkIQkzjpUoTuKaSYHZarts_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B91 RID: 19345 RVA: 0x0015959C File Offset: 0x0015779C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310270, XrefRangeEnd = 310271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int gaBUEUqatjrgPCMWjsWkDtcyfkH()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_gaBUEUqatjrgPCMWjsWkDtcyfkH_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B92 RID: 19346 RVA: 0x001595D8 File Offset: 0x001577D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310271, XrefRangeEnd = 310272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool cxsItqtnnCKOIWotbScepGOOxgS()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_cxsItqtnnCKOIWotbScepGOOxgS_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B93 RID: 19347 RVA: 0x00159614 File Offset: 0x00157814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310272, XrefRangeEnd = 310273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Color cJFCvlZPbtJRhImbVbbcbCcBxjnV()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_cJFCvlZPbtJRhImbVbbcbCcBxjnV_Public_Virtual_Final_New_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B94 RID: 19348 RVA: 0x00159650 File Offset: 0x00157850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310273, XrefRangeEnd = 310274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int DhkgVIURIDfREFmBfpWljnxOSJnl()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DhkgVIURIDfREFmBfpWljnxOSJnl_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B95 RID: 19349 RVA: 0x0015968C File Offset: 0x0015788C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310274, XrefRangeEnd = 310275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string ajLaezphWudFNBGiotEROuYayZdF()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ajLaezphWudFNBGiotEROuYayZdF_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x170017C4 RID: 6084
			// (get) Token: 0x06004B96 RID: 19350 RVA: 0x001596C4 File Offset: 0x001578C4
			public unsafe virtual int vibrationMotorCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B97 RID: 19351 RVA: 0x00159700 File Offset: 0x00157900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310275, XrefRangeEnd = 310278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void StopVibration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B98 RID: 19352 RVA: 0x00159734 File Offset: 0x00157934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310278, XrefRangeEnd = 310279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetVibration(int motorIndex, float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref motorIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B99 RID: 19353 RVA: 0x00159780 File Offset: 0x00157980
			[CallerCount(0)]
			public unsafe virtual float GetVibration(int motorIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref motorIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004B9A RID: 19354 RVA: 0x001597CC File Offset: 0x001579CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310279, XrefRangeEnd = 310283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetMotionSensorState(bool enabled)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetMotionSensorState_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B9B RID: 19355 RVA: 0x0015980C File Offset: 0x00157A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310283, XrefRangeEnd = 310287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetTiltCorrectionState(bool enabled)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetTiltCorrectionState_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B9C RID: 19356 RVA: 0x0015984C File Offset: 0x00157A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310287, XrefRangeEnd = 310291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetAngularVelocityDeadbandState(bool enabled)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004B9D RID: 19357 RVA: 0x0015988C File Offset: 0x00157A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310291, XrefRangeEnd = 310295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ResetOrientation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B9E RID: 19358 RVA: 0x001598C0 File Offset: 0x00157AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310295, XrefRangeEnd = 310304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Vector3 GetLastAcceleration()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastAcceleration_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004B9F RID: 19359 RVA: 0x001598FC File Offset: 0x00157AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310304, XrefRangeEnd = 310310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Vector3 GetLastAccelerationRaw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BA0 RID: 19360 RVA: 0x00159938 File Offset: 0x00157B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310310, XrefRangeEnd = 310319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Vector3 GetLastGyro()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastGyro_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BA1 RID: 19361 RVA: 0x00159974 File Offset: 0x00157B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310319, XrefRangeEnd = 310325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Vector3 GetLastGyroRaw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastGyroRaw_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BA2 RID: 19362 RVA: 0x001599B0 File Offset: 0x00157BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310325, XrefRangeEnd = 310331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Quaternion GetLastOrientation()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastOrientation_Public_Virtual_Final_New_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BA3 RID: 19363 RVA: 0x001599EC File Offset: 0x00157BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310331, XrefRangeEnd = 310337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Quaternion GetLastOrientationRaw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_GetLastOrientationRaw_Public_Virtual_Final_New_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BA4 RID: 19364 RVA: 0x00159A28 File Offset: 0x00157C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310337, XrefRangeEnd = 310340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetLightColor(int red, int green, int blue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref red;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BA5 RID: 19365 RVA: 0x00159A84 File Offset: 0x00157C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310340, XrefRangeEnd = 310344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ResetLight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ResetLight_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BA6 RID: 19366 RVA: 0x00159AB8 File Offset: 0x00157CB8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 310452, RefRangeEnd = 310457, XrefRangeStart = 310344, XrefRangeEnd = 310452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BA7 RID: 19367 RVA: 0x00159AF4 File Offset: 0x00157CF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310466, RefRangeEnd = 310468, XrefRangeStart = 310457, XrefRangeEnd = 310466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void hPdBrvEfhFajovIsXuYWCWotLqj()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_hPdBrvEfhFajovIsXuYWCWotLqj_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BA8 RID: 19368 RVA: 0x00159B28 File Offset: 0x00157D28
			[CallerCount(0)]
			public unsafe static int tbPWEBktbgCkRItSMDZSKpOXHlG(float A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_tbPWEBktbgCkRItSMDZSKpOXHlG_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BA9 RID: 19369 RVA: 0x00159B68 File Offset: 0x00157D68
			[CallerCount(0)]
			public unsafe static void DtptwGvMHHWYtiObmjGUBSGKWWS(ref Vector3 A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Public_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BAA RID: 19370 RVA: 0x00159B9C File Offset: 0x00157D9C
			[CallerCount(0)]
			public unsafe static void ThbIRbwHDVgOvNnDNaPNIFyStTC(ref Vector3 A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &A_0;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Public_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004BAB RID: 19371 RVA: 0x00159BD0 File Offset: 0x00157DD0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310523, RefRangeEnd = 310524, XrefRangeStart = 310468, XrefRangeEnd = 310523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool WrBNencOXMZfhInCDSFUXHoEqMG(int A_0, out PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeMethodInfoPtr_WrBNencOXMZfhInCDSFUXHoEqMG_Public_Static_Boolean_Int32_byref_ControllerType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BAC RID: 19372 RVA: 0x0001BD62 File Offset: 0x00019F62
			public LyCIqIDJtLWQqrFEYaPMYMsNSIg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017A9 RID: 6057
			// (get) Token: 0x06004BAD RID: 19373 RVA: 0x00159C1C File Offset: 0x00157E1C
			// (set) Token: 0x06004BAE RID: 19374 RVA: 0x0001BD6B File Offset: 0x00019F6B
			public unsafe static int FFRIJQiRpcjmvyHmvccRmfqGnYSL
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_FFRIJQiRpcjmvyHmvccRmfqGnYSL, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_FFRIJQiRpcjmvyHmvccRmfqGnYSL, (void*)(&value));
				}
			}

			// Token: 0x170017AA RID: 6058
			// (get) Token: 0x06004BAF RID: 19375 RVA: 0x00159C38 File Offset: 0x00157E38
			// (set) Token: 0x06004BB0 RID: 19376 RVA: 0x0001BD79 File Offset: 0x00019F79
			public unsafe int HFDLhMjPFtSioLkrcDMAnXTYLIS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS)) = value;
				}
			}

			// Token: 0x170017AB RID: 6059
			// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x00159C60 File Offset: 0x00157E60
			// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x0001BD94 File Offset: 0x00019F94
			public unsafe int tmaZQesVbebeMFeNJRRBihbXdrY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tmaZQesVbebeMFeNJRRBihbXdrY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tmaZQesVbebeMFeNJRRBihbXdrY)) = value;
				}
			}

			// Token: 0x170017AC RID: 6060
			// (get) Token: 0x06004BB3 RID: 19379 RVA: 0x00159C88 File Offset: 0x00157E88
			// (set) Token: 0x06004BB4 RID: 19380 RVA: 0x0001BDAF File Offset: 0x00019FAF
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.BaseControllerType qRwyKkFordpovHnVqZQlchaIjAtD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qRwyKkFordpovHnVqZQlchaIjAtD);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qRwyKkFordpovHnVqZQlchaIjAtD)) = value;
				}
			}

			// Token: 0x170017AD RID: 6061
			// (get) Token: 0x06004BB5 RID: 19381 RVA: 0x00159CB0 File Offset: 0x00157EB0
			// (set) Token: 0x06004BB6 RID: 19382 RVA: 0x0001BDCA File Offset: 0x00019FCA
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl frUicbyQRnhQVJOljiuGIowdDCn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_frUicbyQRnhQVJOljiuGIowdDCn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_frUicbyQRnhQVJOljiuGIowdDCn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017AE RID: 6062
			// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x00159CE0 File Offset: 0x00157EE0
			// (set) Token: 0x06004BB8 RID: 19384 RVA: 0x0001BDE9 File Offset: 0x00019FE9
			public unsafe int cHXgUkbCYeKQEnSQvuoKhZJTsUc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc)) = value;
				}
			}

			// Token: 0x170017AF RID: 6063
			// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x00159D08 File Offset: 0x00157F08
			// (set) Token: 0x06004BBA RID: 19386 RVA: 0x0001BE04 File Offset: 0x0001A004
			public unsafe Il2CppStructArray<float> XJThhTpGwcteqUMXRPwcSWMNevg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XJThhTpGwcteqUMXRPwcSWMNevg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XJThhTpGwcteqUMXRPwcSWMNevg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B0 RID: 6064
			// (get) Token: 0x06004BBB RID: 19387 RVA: 0x00159D38 File Offset: 0x00157F38
			// (set) Token: 0x06004BBC RID: 19388 RVA: 0x0001BE23 File Offset: 0x0001A023
			public unsafe LoggedInUser qLhoxMbZgcTrbKiTspiqoqIFplx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qLhoxMbZgcTrbKiTspiqoqIFplx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggedInUser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_qLhoxMbZgcTrbKiTspiqoqIFplx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B1 RID: 6065
			// (get) Token: 0x06004BBD RID: 19389 RVA: 0x00159D68 File Offset: 0x00157F68
			// (set) Token: 0x06004BBE RID: 19390 RVA: 0x0001BE42 File Offset: 0x0001A042
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType HLmDmUQWoPLmPsyHTHuhoXXcGIu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu)) = value;
				}
			}

			// Token: 0x170017B2 RID: 6066
			// (get) Token: 0x06004BBF RID: 19391 RVA: 0x00159D90 File Offset: 0x00157F90
			// (set) Token: 0x06004BC0 RID: 19392 RVA: 0x0001BE5D File Offset: 0x0001A05D
			public unsafe Func<int, bool> nsrnORqQJOUaTIvFXuqOObaIeHoa
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_nsrnORqQJOUaTIvFXuqOObaIeHoa);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_nsrnORqQJOUaTIvFXuqOObaIeHoa), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B3 RID: 6067
			// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x00159DC0 File Offset: 0x00157FC0
			// (set) Token: 0x06004BC2 RID: 19394 RVA: 0x0001BE7C File Offset: 0x0001A07C
			public unsafe Action<int, int, int> UlBhmBCQiqZlfmzenfjnGElgKgeF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_UlBhmBCQiqZlfmzenfjnGElgKgeF);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_UlBhmBCQiqZlfmzenfjnGElgKgeF), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B4 RID: 6068
			// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x00159DF0 File Offset: 0x00157FF0
			// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x0001BE9B File Offset: 0x0001A09B
			public unsafe Action<int, int, int, int> PIjrUXRojQVGqOUbiJTbjBRoCIxG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_PIjrUXRojQVGqOUbiJTbjBRoCIxG);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int, int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_PIjrUXRojQVGqOUbiJTbjBRoCIxG), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B5 RID: 6069
			// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x00159E20 File Offset: 0x00158020
			// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x0001BEBA File Offset: 0x0001A0BA
			public unsafe Action<int> BUbFxqLeJQvsaOvHtRiOFbJPqXw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_BUbFxqLeJQvsaOvHtRiOFbJPqXw);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_BUbFxqLeJQvsaOvHtRiOFbJPqXw), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B6 RID: 6070
			// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00159E50 File Offset: 0x00158050
			// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x0001BED9 File Offset: 0x0001A0D9
			public unsafe Action<int, bool> eZEEUEduIslFKkCagzFeJSxJHud
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_eZEEUEduIslFKkCagzFeJSxJHud);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_eZEEUEduIslFKkCagzFeJSxJHud), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B7 RID: 6071
			// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x00159E80 File Offset: 0x00158080
			// (set) Token: 0x06004BCA RID: 19402 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
			public unsafe Action<int, bool> sxZTRZhhUPxfeNxwcLngQiLybfU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_sxZTRZhhUPxfeNxwcLngQiLybfU);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_sxZTRZhhUPxfeNxwcLngQiLybfU), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B8 RID: 6072
			// (get) Token: 0x06004BCB RID: 19403 RVA: 0x00159EB0 File Offset: 0x001580B0
			// (set) Token: 0x06004BCC RID: 19404 RVA: 0x0001BF17 File Offset: 0x0001A117
			public unsafe Action<int, bool> EIELmfoRApIkoEMCvByrAykynYE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_EIELmfoRApIkoEMCvByrAykynYE);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_EIELmfoRApIkoEMCvByrAykynYE), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017B9 RID: 6073
			// (get) Token: 0x06004BCD RID: 19405 RVA: 0x00159EE0 File Offset: 0x001580E0
			// (set) Token: 0x06004BCE RID: 19406 RVA: 0x0001BF36 File Offset: 0x0001A136
			public unsafe Action<int> XFSjlibMPasPvkhIUNgsNOpzFPj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XFSjlibMPasPvkhIUNgsNOpzFPj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_XFSjlibMPasPvkhIUNgsNOpzFPj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BA RID: 6074
			// (get) Token: 0x06004BCF RID: 19407 RVA: 0x00159F10 File Offset: 0x00158110
			// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x0001BF55 File Offset: 0x0001A155
			public unsafe Func<int, Vector3> bwxgYexINwapNhjDthjEmZxvRBrD
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_bwxgYexINwapNhjDthjEmZxvRBrD);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_bwxgYexINwapNhjDthjEmZxvRBrD), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BB RID: 6075
			// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x00159F40 File Offset: 0x00158140
			// (set) Token: 0x06004BD2 RID: 19410 RVA: 0x0001BF74 File Offset: 0x0001A174
			public unsafe Func<int, Vector3> tOqhJOgvYEMiAcbyQfHiKOMXADbo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tOqhJOgvYEMiAcbyQfHiKOMXADbo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_tOqhJOgvYEMiAcbyQfHiKOMXADbo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017BC RID: 6076
			// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x00159F70 File Offset: 0x00158170
			// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x0001BF93 File Offset: 0x0001A193
			public unsafe Func<int, Vector4> JwlbaJVgTfQEUccsRAvXaXMlBVhp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_JwlbaJVgTfQEUccsRAvXaXMlBVhp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.NativeFieldInfoPtr_JwlbaJVgTfQEUccsRAvXaXMlBVhp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D0A RID: 15626
			private static readonly IntPtr NativeFieldInfoPtr_FFRIJQiRpcjmvyHmvccRmfqGnYSL;

			// Token: 0x04003D0B RID: 15627
			private static readonly IntPtr NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS;

			// Token: 0x04003D0C RID: 15628
			private static readonly IntPtr NativeFieldInfoPtr_tmaZQesVbebeMFeNJRRBihbXdrY;

			// Token: 0x04003D0D RID: 15629
			private static readonly IntPtr NativeFieldInfoPtr_qRwyKkFordpovHnVqZQlchaIjAtD;

			// Token: 0x04003D0E RID: 15630
			private static readonly IntPtr NativeFieldInfoPtr_frUicbyQRnhQVJOljiuGIowdDCn;

			// Token: 0x04003D0F RID: 15631
			private static readonly IntPtr NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc;

			// Token: 0x04003D10 RID: 15632
			private static readonly IntPtr NativeFieldInfoPtr_XJThhTpGwcteqUMXRPwcSWMNevg;

			// Token: 0x04003D11 RID: 15633
			private static readonly IntPtr NativeFieldInfoPtr_qLhoxMbZgcTrbKiTspiqoqIFplx;

			// Token: 0x04003D12 RID: 15634
			private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

			// Token: 0x04003D13 RID: 15635
			private static readonly IntPtr NativeFieldInfoPtr_nsrnORqQJOUaTIvFXuqOObaIeHoa;

			// Token: 0x04003D14 RID: 15636
			private static readonly IntPtr NativeFieldInfoPtr_UlBhmBCQiqZlfmzenfjnGElgKgeF;

			// Token: 0x04003D15 RID: 15637
			private static readonly IntPtr NativeFieldInfoPtr_PIjrUXRojQVGqOUbiJTbjBRoCIxG;

			// Token: 0x04003D16 RID: 15638
			private static readonly IntPtr NativeFieldInfoPtr_BUbFxqLeJQvsaOvHtRiOFbJPqXw;

			// Token: 0x04003D17 RID: 15639
			private static readonly IntPtr NativeFieldInfoPtr_eZEEUEduIslFKkCagzFeJSxJHud;

			// Token: 0x04003D18 RID: 15640
			private static readonly IntPtr NativeFieldInfoPtr_sxZTRZhhUPxfeNxwcLngQiLybfU;

			// Token: 0x04003D19 RID: 15641
			private static readonly IntPtr NativeFieldInfoPtr_EIELmfoRApIkoEMCvByrAykynYE;

			// Token: 0x04003D1A RID: 15642
			private static readonly IntPtr NativeFieldInfoPtr_XFSjlibMPasPvkhIUNgsNOpzFPj;

			// Token: 0x04003D1B RID: 15643
			private static readonly IntPtr NativeFieldInfoPtr_bwxgYexINwapNhjDthjEmZxvRBrD;

			// Token: 0x04003D1C RID: 15644
			private static readonly IntPtr NativeFieldInfoPtr_tOqhJOgvYEMiAcbyQfHiKOMXADbo;

			// Token: 0x04003D1D RID: 15645
			private static readonly IntPtr NativeFieldInfoPtr_JwlbaJVgTfQEUccsRAvXaXMlBVhp;

			// Token: 0x04003D1E RID: 15646
			private static readonly IntPtr NativeMethodInfoPtr_get_NextSystemId_Private_Static_get_Int32_0;

			// Token: 0x04003D1F RID: 15647
			private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_LyCIqIDJtLWQqrFEYaPMYMsNSIg_ControllerType_Int32_Int32_Int32_0;

			// Token: 0x04003D20 RID: 15648
			private static readonly IntPtr NativeMethodInfoPtr_get_user_Protected_get_LoggedInUser_0;

			// Token: 0x04003D21 RID: 15649
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_ControllerType_0;

			// Token: 0x04003D22 RID: 15650
			private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

			// Token: 0x04003D23 RID: 15651
			private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

			// Token: 0x04003D24 RID: 15652
			private static readonly IntPtr NativeMethodInfoPtr_get_baseControllerType_Public_get_BaseControllerType_0;

			// Token: 0x04003D25 RID: 15653
			private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectedNow_Private_get_Boolean_0;

			// Token: 0x04003D26 RID: 15654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_BaseControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0;

			// Token: 0x04003D27 RID: 15655
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0;

			// Token: 0x04003D28 RID: 15656
			private static readonly IntPtr NativeMethodInfoPtr_ltrLYnhSCHjNmOJneCQmUuVLGKg_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D29 RID: 15657
			private static readonly IntPtr NativeMethodInfoPtr_sioUuDkIQkzjpUoTuKaSYHZarts_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D2A RID: 15658
			private static readonly IntPtr NativeMethodInfoPtr_gaBUEUqatjrgPCMWjsWkDtcyfkH_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D2B RID: 15659
			private static readonly IntPtr NativeMethodInfoPtr_cxsItqtnnCKOIWotbScepGOOxgS_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D2C RID: 15660
			private static readonly IntPtr NativeMethodInfoPtr_cJFCvlZPbtJRhImbVbbcbCcBxjnV_Public_Virtual_Final_New_Color_0;

			// Token: 0x04003D2D RID: 15661
			private static readonly IntPtr NativeMethodInfoPtr_DhkgVIURIDfREFmBfpWljnxOSJnl_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D2E RID: 15662
			private static readonly IntPtr NativeMethodInfoPtr_ajLaezphWudFNBGiotEROuYayZdF_Public_Virtual_Final_New_String_0;

			// Token: 0x04003D2F RID: 15663
			private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003D30 RID: 15664
			private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003D31 RID: 15665
			private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;

			// Token: 0x04003D32 RID: 15666
			private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;

			// Token: 0x04003D33 RID: 15667
			private static readonly IntPtr NativeMethodInfoPtr_SetMotionSensorState_Public_Virtual_Final_New_Void_Boolean_0;

			// Token: 0x04003D34 RID: 15668
			private static readonly IntPtr NativeMethodInfoPtr_SetTiltCorrectionState_Public_Virtual_Final_New_Void_Boolean_0;

			// Token: 0x04003D35 RID: 15669
			private static readonly IntPtr NativeMethodInfoPtr_SetAngularVelocityDeadbandState_Public_Virtual_Final_New_Void_Boolean_0;

			// Token: 0x04003D36 RID: 15670
			private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003D37 RID: 15671
			private static readonly IntPtr NativeMethodInfoPtr_GetLastAcceleration_Public_Virtual_Final_New_Vector3_0;

			// Token: 0x04003D38 RID: 15672
			private static readonly IntPtr NativeMethodInfoPtr_GetLastAccelerationRaw_Public_Virtual_Final_New_Vector3_0;

			// Token: 0x04003D39 RID: 15673
			private static readonly IntPtr NativeMethodInfoPtr_GetLastGyro_Public_Virtual_Final_New_Vector3_0;

			// Token: 0x04003D3A RID: 15674
			private static readonly IntPtr NativeMethodInfoPtr_GetLastGyroRaw_Public_Virtual_Final_New_Vector3_0;

			// Token: 0x04003D3B RID: 15675
			private static readonly IntPtr NativeMethodInfoPtr_GetLastOrientation_Public_Virtual_Final_New_Quaternion_0;

			// Token: 0x04003D3C RID: 15676
			private static readonly IntPtr NativeMethodInfoPtr_GetLastOrientationRaw_Public_Virtual_Final_New_Quaternion_0;

			// Token: 0x04003D3D RID: 15677
			private static readonly IntPtr NativeMethodInfoPtr_SetLightColor_Public_Virtual_Final_New_Void_Int32_Int32_Int32_0;

			// Token: 0x04003D3E RID: 15678
			private static readonly IntPtr NativeMethodInfoPtr_ResetLight_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003D3F RID: 15679
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_New_Void_0;

			// Token: 0x04003D40 RID: 15680
			private static readonly IntPtr NativeMethodInfoPtr_hPdBrvEfhFajovIsXuYWCWotLqj_Protected_Void_0;

			// Token: 0x04003D41 RID: 15681
			private static readonly IntPtr NativeMethodInfoPtr_tbPWEBktbgCkRItSMDZSKpOXHlG_Public_Static_Int32_Single_0;

			// Token: 0x04003D42 RID: 15682
			private static readonly IntPtr NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Public_Static_Void_byref_Vector3_0;

			// Token: 0x04003D43 RID: 15683
			private static readonly IntPtr NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Public_Static_Void_byref_Vector3_0;

			// Token: 0x04003D44 RID: 15684
			private static readonly IntPtr NativeMethodInfoPtr_WrBNencOXMZfhInCDSFUXHoEqMG_Public_Static_Boolean_Int32_byref_ControllerType_0;

			// Token: 0x02000594 RID: 1428
			[OriginalName("Rewired_Core.dll", "", "ControllerType")]
			public enum ControllerType
			{
				// Token: 0x04004E3D RID: 20029
				Unknown,
				// Token: 0x04004E3E RID: 20030
				Gamepad,
				// Token: 0x04004E3F RID: 20031
				Aim,
				// Token: 0x04004E40 RID: 20032
				Guitar,
				// Token: 0x04004E41 RID: 20033
				Drum,
				// Token: 0x04004E42 RID: 20034
				DjTurntable,
				// Token: 0x04004E43 RID: 20035
				DanceMat,
				// Token: 0x04004E44 RID: 20036
				Navigation,
				// Token: 0x04004E45 RID: 20037
				SteeringWheel,
				// Token: 0x04004E46 RID: 20038
				Stick,
				// Token: 0x04004E47 RID: 20039
				FlightStick,
				// Token: 0x04004E48 RID: 20040
				Gun
			}

			// Token: 0x02000595 RID: 1429
			[OriginalName("Rewired_Core.dll", "", "PCXeyyCrNyOiwMIUwfLidluIgOlc")]
			public enum PCXeyyCrNyOiwMIUwfLidluIgOlc
			{
				// Token: 0x04004E4A RID: 20042
				pbEwUmgtedTWksLWRJLxjjXcbkR,
				// Token: 0x04004E4B RID: 20043
				glmUnoTyGOfodHWALudoSGYzwAo,
				// Token: 0x04004E4C RID: 20044
				UKQkxjkDJCjpzSzSwzWIkNiqBJZ
			}

			// Token: 0x02000596 RID: 1430
			[OriginalName("Rewired_Core.dll", "", "BaseControllerType")]
			public enum BaseControllerType
			{
				// Token: 0x04004E4E RID: 20046
				Gamepad,
				// Token: 0x04004E4F RID: 20047
				Special,
				// Token: 0x04004E50 RID: 20048
				Aim
			}

			// Token: 0x02000597 RID: 1431
			public class XxiUOabMRIxtVIZMXEYmPJEBKwl : global::Il2CppSystem.Object
			{
				// Token: 0x06005F6F RID: 24431 RVA: 0x001A7F04 File Offset: 0x001A6104
				// Note: this type is marked as 'beforefieldinit'.
				static XxiUOabMRIxtVIZMXEYmPJEBKwl()
				{
					Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg>.NativeClassPtr, "XxiUOabMRIxtVIZMXEYmPJEBKwl");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr);
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, "yHQIcUwPwDJrWehFwcGOARwxPjqk");
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, "fSxjFgmrrcJImiPcAahGHVTZRLqI");
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_acMgyuTJEoyBnkLCdSwDhHyXLMT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, "acMgyuTJEoyBnkLCdSwDhHyXLMT");
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, "IrPGdvpUHdQviBLkVmFelgVaPvu");
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_wkOhGFVYUzDUhlqiArWMYDrwEIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, "wkOhGFVYUzDUhlqiArWMYDrwEIK");
					PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr, 100673380);
				}

				// Token: 0x06005F70 RID: 24432 RVA: 0x001A7FA8 File Offset: 0x001A61A8
				[CallerCount(0)]
				public unsafe XxiUOabMRIxtVIZMXEYmPJEBKwl(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref axisCount;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpadDeadzone;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrationMotorCount;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTouches;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005F71 RID: 24433 RVA: 0x00023571 File Offset: 0x00021771
				public XxiUOabMRIxtVIZMXEYmPJEBKwl(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001D06 RID: 7430
				// (get) Token: 0x06005F72 RID: 24434 RVA: 0x001A8028 File Offset: 0x001A6228
				// (set) Token: 0x06005F73 RID: 24435 RVA: 0x0002357A File Offset: 0x0002177A
				public unsafe int yHQIcUwPwDJrWehFwcGOARwxPjqk
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk)) = value;
					}
				}

				// Token: 0x17001D07 RID: 7431
				// (get) Token: 0x06005F74 RID: 24436 RVA: 0x001A8050 File Offset: 0x001A6250
				// (set) Token: 0x06005F75 RID: 24437 RVA: 0x00023595 File Offset: 0x00021795
				public unsafe int fSxjFgmrrcJImiPcAahGHVTZRLqI
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI)) = value;
					}
				}

				// Token: 0x17001D08 RID: 7432
				// (get) Token: 0x06005F76 RID: 24438 RVA: 0x001A8078 File Offset: 0x001A6278
				// (set) Token: 0x06005F77 RID: 24439 RVA: 0x000235B0 File Offset: 0x000217B0
				public unsafe float acMgyuTJEoyBnkLCdSwDhHyXLMT
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_acMgyuTJEoyBnkLCdSwDhHyXLMT);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_acMgyuTJEoyBnkLCdSwDhHyXLMT)) = value;
					}
				}

				// Token: 0x17001D09 RID: 7433
				// (get) Token: 0x06005F78 RID: 24440 RVA: 0x001A80A0 File Offset: 0x001A62A0
				// (set) Token: 0x06005F79 RID: 24441 RVA: 0x000235CB File Offset: 0x000217CB
				public unsafe int IrPGdvpUHdQviBLkVmFelgVaPvu
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu)) = value;
					}
				}

				// Token: 0x17001D0A RID: 7434
				// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001A80C8 File Offset: 0x001A62C8
				// (set) Token: 0x06005F7B RID: 24443 RVA: 0x000235E6 File Offset: 0x000217E6
				public unsafe int wkOhGFVYUzDUhlqiArWMYDrwEIK
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_wkOhGFVYUzDUhlqiArWMYDrwEIK);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl.NativeFieldInfoPtr_wkOhGFVYUzDUhlqiArWMYDrwEIK)) = value;
					}
				}

				// Token: 0x04004E51 RID: 20049
				private static readonly IntPtr NativeFieldInfoPtr_yHQIcUwPwDJrWehFwcGOARwxPjqk;

				// Token: 0x04004E52 RID: 20050
				private static readonly IntPtr NativeFieldInfoPtr_fSxjFgmrrcJImiPcAahGHVTZRLqI;

				// Token: 0x04004E53 RID: 20051
				private static readonly IntPtr NativeFieldInfoPtr_acMgyuTJEoyBnkLCdSwDhHyXLMT;

				// Token: 0x04004E54 RID: 20052
				private static readonly IntPtr NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu;

				// Token: 0x04004E55 RID: 20053
				private static readonly IntPtr NativeFieldInfoPtr_wkOhGFVYUzDUhlqiArWMYDrwEIK;

				// Token: 0x04004E56 RID: 20054
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Int32_Int32_0;
			}
		}

		// Token: 0x02000390 RID: 912
		public sealed class SXRCsHXOHuLwTnBOmHeOhKlxXFXj : PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg
		{
			// Token: 0x06004BD5 RID: 19413 RVA: 0x00159FA0 File Offset: 0x001581A0
			// Note: this type is marked as 'beforefieldinit'.
			static SXRCsHXOHuLwTnBOmHeOhKlxXFXj()
			{
				Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "SXRCsHXOHuLwTnBOmHeOhKlxXFXj");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "bBEzdgoNfdcKjGITcYtpxUysZxH");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "AAhMvogABXMcIYmCDhiRnouGqFA");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "oKXebCllqksgncucZdWWvDaypsz");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "PSVHoCiIoVzUinjYxIxmaGCxuwA");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "wALaxoadcbzCdqyLfHBRcaIqAseA");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "phNPjhUkLMBADpEAbGabYcbZWwM");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "FvSYthLIDogxqHWFRUVctEAQkehU");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "PjCWxdWeCARHLBQcUGpEHCmLMVcJ");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "BVKNVuXycMBlctWTILPMCMsEYBt");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "oQFakviQAOBxaHrLCZZBTGIJtuR");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, "ibvCyMefpddmFeLLhWFZEVcGhrKu");
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673381);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetConnectionType_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673382);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673383);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673384);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673385);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPixelDensity_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673386);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673387);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673388);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673389);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673390);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673391);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673392);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673393);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673394);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_IsTouchingByIndex_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673395);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673396);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673397);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673398);
				PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_jQvCosnIEeeaYNudCqlyVGpRHcQA_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr, 100673399);
			}

			// Token: 0x06004BD6 RID: 19414 RVA: 0x0015A288 File Offset: 0x00158488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310524, XrefRangeEnd = 310544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SXRCsHXOHuLwTnBOmHeOhKlxXFXj(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BD7 RID: 19415 RVA: 0x0015A300 File Offset: 0x00158500
			[CallerCount(0)]
			public unsafe int GetConnectionType()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetConnectionType_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BD8 RID: 19416 RVA: 0x0015A33C File Offset: 0x0015853C
			[CallerCount(0)]
			public unsafe int GetAnalogDeadZoneLeft()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BD9 RID: 19417 RVA: 0x0015A378 File Offset: 0x00158578
			[CallerCount(0)]
			public unsafe int GetAnalogDeadZoneRight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170017D5 RID: 6101
			// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0015A3B4 File Offset: 0x001585B4
			public unsafe int maxTouches
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BDB RID: 19419 RVA: 0x0015A3F0 File Offset: 0x001585F0
			[CallerCount(0)]
			public unsafe float GetTouchPixelDensity()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPixelDensity_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BDC RID: 19420 RVA: 0x0015A42C File Offset: 0x0015862C
			[CallerCount(0)]
			public unsafe int GetTouchpadResolutionX()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BDD RID: 19421 RVA: 0x0015A468 File Offset: 0x00158668
			[CallerCount(0)]
			public unsafe int GetTouchpadResolutionY()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BDE RID: 19422 RVA: 0x0015A4A4 File Offset: 0x001586A4
			[CallerCount(0)]
			public unsafe int GetTouchCount()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BDF RID: 19423 RVA: 0x0015A4E0 File Offset: 0x001586E0
			[CallerCount(0)]
			public unsafe int GetTouchId(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BE0 RID: 19424 RVA: 0x0015A52C File Offset: 0x0015872C
			[CallerCount(0)]
			public unsafe bool GetTouchPositionAbsByIndex(int index, out Vector2 position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BE1 RID: 19425 RVA: 0x0015A584 File Offset: 0x00158784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310544, XrefRangeEnd = 310545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GetTouchPositionAbsByTouchId(int touchId, out Vector2 position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref touchId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BE2 RID: 19426 RVA: 0x0015A5DC File Offset: 0x001587DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310545, XrefRangeEnd = 310546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GetTouchPositionByIndex(int index, out Vector2 position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BE3 RID: 19427 RVA: 0x0015A634 File Offset: 0x00158834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310546, XrefRangeEnd = 310548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref touchId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BE4 RID: 19428 RVA: 0x0015A68C File Offset: 0x0015888C
			[CallerCount(0)]
			public unsafe bool IsTouchingByIndex(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_IsTouchingByIndex_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BE5 RID: 19429 RVA: 0x0015A6D8 File Offset: 0x001588D8
			[CallerCount(0)]
			public unsafe bool IsTouchingByTouchId(int touchId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref touchId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BE6 RID: 19430 RVA: 0x0015A724 File Offset: 0x00158924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310548, XrefRangeEnd = 310556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BE7 RID: 19431 RVA: 0x0015A758 File Offset: 0x00158958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310556, XrefRangeEnd = 310565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QfGPTYLRgCyphPGiTguxvWucxER()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BE8 RID: 19432 RVA: 0x0015A78C File Offset: 0x0015898C
			[CallerCount(0)]
			public unsafe int jQvCosnIEeeaYNudCqlyVGpRHcQA(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeMethodInfoPtr_jQvCosnIEeeaYNudCqlyVGpRHcQA_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BE9 RID: 19433 RVA: 0x0001BFB2 File Offset: 0x0001A1B2
			public SXRCsHXOHuLwTnBOmHeOhKlxXFXj(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017C5 RID: 6085
			// (get) Token: 0x06004BEA RID: 19434 RVA: 0x0015A7D8 File Offset: 0x001589D8
			// (set) Token: 0x06004BEB RID: 19435 RVA: 0x0001BFBB File Offset: 0x0001A1BB
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017C6 RID: 6086
			// (get) Token: 0x06004BEC RID: 19436 RVA: 0x0015A7F4 File Offset: 0x001589F4
			// (set) Token: 0x06004BED RID: 19437 RVA: 0x0001BFC9 File Offset: 0x0001A1C9
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017C7 RID: 6087
			// (get) Token: 0x06004BEE RID: 19438 RVA: 0x0015A810 File Offset: 0x00158A10
			// (set) Token: 0x06004BEF RID: 19439 RVA: 0x0001BFD7 File Offset: 0x0001A1D7
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017C8 RID: 6088
			// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x0015A82C File Offset: 0x00158A2C
			// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x0001BFE5 File Offset: 0x0001A1E5
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017C9 RID: 6089
			// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0015A848 File Offset: 0x00158A48
			// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x0001BFF3 File Offset: 0x0001A1F3
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x170017CA RID: 6090
			// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x0015A864 File Offset: 0x00158A64
			// (set) Token: 0x06004BF5 RID: 19445 RVA: 0x0001C001 File Offset: 0x0001A201
			public unsafe int bBEzdgoNfdcKjGITcYtpxUysZxH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH)) = value;
				}
			}

			// Token: 0x170017CB RID: 6091
			// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x0015A88C File Offset: 0x00158A8C
			// (set) Token: 0x06004BF7 RID: 19447 RVA: 0x0001C01C File Offset: 0x0001A21C
			public unsafe int AAhMvogABXMcIYmCDhiRnouGqFA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA)) = value;
				}
			}

			// Token: 0x170017CC RID: 6092
			// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x0015A8B4 File Offset: 0x00158AB4
			// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x0001C037 File Offset: 0x0001A237
			public unsafe Vector2 oKXebCllqksgncucZdWWvDaypsz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz)) = value;
				}
			}

			// Token: 0x170017CD RID: 6093
			// (get) Token: 0x06004BFA RID: 19450 RVA: 0x0015A8DC File Offset: 0x00158ADC
			// (set) Token: 0x06004BFB RID: 19451 RVA: 0x0001C052 File Offset: 0x0001A252
			public unsafe int PSVHoCiIoVzUinjYxIxmaGCxuwA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA)) = value;
				}
			}

			// Token: 0x170017CE RID: 6094
			// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0015A904 File Offset: 0x00158B04
			// (set) Token: 0x06004BFD RID: 19453 RVA: 0x0001C06D File Offset: 0x0001A26D
			public unsafe Vector2 wALaxoadcbzCdqyLfHBRcaIqAseA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA)) = value;
				}
			}

			// Token: 0x170017CF RID: 6095
			// (get) Token: 0x06004BFE RID: 19454 RVA: 0x0015A92C File Offset: 0x00158B2C
			// (set) Token: 0x06004BFF RID: 19455 RVA: 0x0001C088 File Offset: 0x0001A288
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.PCXeyyCrNyOiwMIUwfLidluIgOlc phNPjhUkLMBADpEAbGabYcbZWwM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM)) = value;
				}
			}

			// Token: 0x170017D0 RID: 6096
			// (get) Token: 0x06004C00 RID: 19456 RVA: 0x0015A954 File Offset: 0x00158B54
			// (set) Token: 0x06004C01 RID: 19457 RVA: 0x0001C0A3 File Offset: 0x0001A2A3
			public unsafe int FvSYthLIDogxqHWFRUVctEAQkehU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU)) = value;
				}
			}

			// Token: 0x170017D1 RID: 6097
			// (get) Token: 0x06004C02 RID: 19458 RVA: 0x0015A97C File Offset: 0x00158B7C
			// (set) Token: 0x06004C03 RID: 19459 RVA: 0x0001C0BE File Offset: 0x0001A2BE
			public unsafe int PjCWxdWeCARHLBQcUGpEHCmLMVcJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ)) = value;
				}
			}

			// Token: 0x170017D2 RID: 6098
			// (get) Token: 0x06004C04 RID: 19460 RVA: 0x0015A9A4 File Offset: 0x00158BA4
			// (set) Token: 0x06004C05 RID: 19461 RVA: 0x0001C0D9 File Offset: 0x0001A2D9
			public unsafe int BVKNVuXycMBlctWTILPMCMsEYBt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt)) = value;
				}
			}

			// Token: 0x170017D3 RID: 6099
			// (get) Token: 0x06004C06 RID: 19462 RVA: 0x0015A9CC File Offset: 0x00158BCC
			// (set) Token: 0x06004C07 RID: 19463 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
			public unsafe int oQFakviQAOBxaHrLCZZBTGIJtuR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR)) = value;
				}
			}

			// Token: 0x170017D4 RID: 6100
			// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0015A9F4 File Offset: 0x00158BF4
			// (set) Token: 0x06004C09 RID: 19465 RVA: 0x0001C10F File Offset: 0x0001A30F
			public unsafe float ibvCyMefpddmFeLLhWFZEVcGhrKu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.SXRCsHXOHuLwTnBOmHeOhKlxXFXj.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu)) = value;
				}
			}

			// Token: 0x04003D45 RID: 15685
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D46 RID: 15686
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D47 RID: 15687
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D48 RID: 15688
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D49 RID: 15689
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D4A RID: 15690
			private static readonly IntPtr NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH;

			// Token: 0x04003D4B RID: 15691
			private static readonly IntPtr NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA;

			// Token: 0x04003D4C RID: 15692
			private static readonly IntPtr NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz;

			// Token: 0x04003D4D RID: 15693
			private static readonly IntPtr NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA;

			// Token: 0x04003D4E RID: 15694
			private static readonly IntPtr NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA;

			// Token: 0x04003D4F RID: 15695
			private static readonly IntPtr NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM;

			// Token: 0x04003D50 RID: 15696
			private static readonly IntPtr NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU;

			// Token: 0x04003D51 RID: 15697
			private static readonly IntPtr NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ;

			// Token: 0x04003D52 RID: 15698
			private static readonly IntPtr NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt;

			// Token: 0x04003D53 RID: 15699
			private static readonly IntPtr NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR;

			// Token: 0x04003D54 RID: 15700
			private static readonly IntPtr NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu;

			// Token: 0x04003D55 RID: 15701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

			// Token: 0x04003D56 RID: 15702
			private static readonly IntPtr NativeMethodInfoPtr_GetConnectionType_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D57 RID: 15703
			private static readonly IntPtr NativeMethodInfoPtr_GetAnalogDeadZoneLeft_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D58 RID: 15704
			private static readonly IntPtr NativeMethodInfoPtr_GetAnalogDeadZoneRight_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D59 RID: 15705
			private static readonly IntPtr NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003D5A RID: 15706
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchPixelDensity_Public_Virtual_Final_New_Single_0;

			// Token: 0x04003D5B RID: 15707
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchpadResolutionX_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D5C RID: 15708
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchpadResolutionY_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D5D RID: 15709
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04003D5E RID: 15710
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0;

			// Token: 0x04003D5F RID: 15711
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

			// Token: 0x04003D60 RID: 15712
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

			// Token: 0x04003D61 RID: 15713
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

			// Token: 0x04003D62 RID: 15714
			private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

			// Token: 0x04003D63 RID: 15715
			private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByIndex_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x04003D64 RID: 15716
			private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x04003D65 RID: 15717
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0;

			// Token: 0x04003D66 RID: 15718
			private static readonly IntPtr NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0;

			// Token: 0x04003D67 RID: 15719
			private static readonly IntPtr NativeMethodInfoPtr_jQvCosnIEeeaYNudCqlyVGpRHcQA_Private_Int32_Int32_0;
		}

		// Token: 0x02000391 RID: 913
		public sealed class iKfKRUNmwsuSkTeodPZvrFyyZZO : PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg
		{
			// Token: 0x06004C0A RID: 19466 RVA: 0x0015AA1C File Offset: 0x00158C1C
			// Note: this type is marked as 'beforefieldinit'.
			static iKfKRUNmwsuSkTeodPZvrFyyZZO()
			{
				Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "iKfKRUNmwsuSkTeodPZvrFyyZZO");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr);
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "bBEzdgoNfdcKjGITcYtpxUysZxH");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "AAhMvogABXMcIYmCDhiRnouGqFA");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "oKXebCllqksgncucZdWWvDaypsz");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "PSVHoCiIoVzUinjYxIxmaGCxuwA");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "wALaxoadcbzCdqyLfHBRcaIqAseA");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "phNPjhUkLMBADpEAbGabYcbZWwM");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "FvSYthLIDogxqHWFRUVctEAQkehU");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "PjCWxdWeCARHLBQcUGpEHCmLMVcJ");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "BVKNVuXycMBlctWTILPMCMsEYBt");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "oQFakviQAOBxaHrLCZZBTGIJtuR");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, "ibvCyMefpddmFeLLhWFZEVcGhrKu");
				PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr, 100673400);
			}

			// Token: 0x06004C0B RID: 19467 RVA: 0x0015AB9C File Offset: 0x00158D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310565, XrefRangeEnd = 310576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe iKfKRUNmwsuSkTeodPZvrFyyZZO(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C0C RID: 19468 RVA: 0x0001C12A File Offset: 0x0001A32A
			public iKfKRUNmwsuSkTeodPZvrFyyZZO(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017D6 RID: 6102
			// (get) Token: 0x06004C0D RID: 19469 RVA: 0x0015AC14 File Offset: 0x00158E14
			// (set) Token: 0x06004C0E RID: 19470 RVA: 0x0001C133 File Offset: 0x0001A333
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017D7 RID: 6103
			// (get) Token: 0x06004C0F RID: 19471 RVA: 0x0015AC30 File Offset: 0x00158E30
			// (set) Token: 0x06004C10 RID: 19472 RVA: 0x0001C141 File Offset: 0x0001A341
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017D8 RID: 6104
			// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0015AC4C File Offset: 0x00158E4C
			// (set) Token: 0x06004C12 RID: 19474 RVA: 0x0001C14F File Offset: 0x0001A34F
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017D9 RID: 6105
			// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0015AC68 File Offset: 0x00158E68
			// (set) Token: 0x06004C14 RID: 19476 RVA: 0x0001C15D File Offset: 0x0001A35D
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017DA RID: 6106
			// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0015AC84 File Offset: 0x00158E84
			// (set) Token: 0x06004C16 RID: 19478 RVA: 0x0001C16B File Offset: 0x0001A36B
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x170017DB RID: 6107
			// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0015ACA0 File Offset: 0x00158EA0
			// (set) Token: 0x06004C18 RID: 19480 RVA: 0x0001C179 File Offset: 0x0001A379
			public unsafe int bBEzdgoNfdcKjGITcYtpxUysZxH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH)) = value;
				}
			}

			// Token: 0x170017DC RID: 6108
			// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0015ACC8 File Offset: 0x00158EC8
			// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0001C194 File Offset: 0x0001A394
			public unsafe int AAhMvogABXMcIYmCDhiRnouGqFA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA)) = value;
				}
			}

			// Token: 0x170017DD RID: 6109
			// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0015ACF0 File Offset: 0x00158EF0
			// (set) Token: 0x06004C1C RID: 19484 RVA: 0x0001C1AF File Offset: 0x0001A3AF
			public unsafe Vector2 oKXebCllqksgncucZdWWvDaypsz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz)) = value;
				}
			}

			// Token: 0x170017DE RID: 6110
			// (get) Token: 0x06004C1D RID: 19485 RVA: 0x0015AD18 File Offset: 0x00158F18
			// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0001C1CA File Offset: 0x0001A3CA
			public unsafe int PSVHoCiIoVzUinjYxIxmaGCxuwA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA)) = value;
				}
			}

			// Token: 0x170017DF RID: 6111
			// (get) Token: 0x06004C1F RID: 19487 RVA: 0x0015AD40 File Offset: 0x00158F40
			// (set) Token: 0x06004C20 RID: 19488 RVA: 0x0001C1E5 File Offset: 0x0001A3E5
			public unsafe Vector2 wALaxoadcbzCdqyLfHBRcaIqAseA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA)) = value;
				}
			}

			// Token: 0x170017E0 RID: 6112
			// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0015AD68 File Offset: 0x00158F68
			// (set) Token: 0x06004C22 RID: 19490 RVA: 0x0001C200 File Offset: 0x0001A400
			public unsafe PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.PCXeyyCrNyOiwMIUwfLidluIgOlc phNPjhUkLMBADpEAbGabYcbZWwM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM)) = value;
				}
			}

			// Token: 0x170017E1 RID: 6113
			// (get) Token: 0x06004C23 RID: 19491 RVA: 0x0015AD90 File Offset: 0x00158F90
			// (set) Token: 0x06004C24 RID: 19492 RVA: 0x0001C21B File Offset: 0x0001A41B
			public unsafe int FvSYthLIDogxqHWFRUVctEAQkehU
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU)) = value;
				}
			}

			// Token: 0x170017E2 RID: 6114
			// (get) Token: 0x06004C25 RID: 19493 RVA: 0x0015ADB8 File Offset: 0x00158FB8
			// (set) Token: 0x06004C26 RID: 19494 RVA: 0x0001C236 File Offset: 0x0001A436
			public unsafe int PjCWxdWeCARHLBQcUGpEHCmLMVcJ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ)) = value;
				}
			}

			// Token: 0x170017E3 RID: 6115
			// (get) Token: 0x06004C27 RID: 19495 RVA: 0x0015ADE0 File Offset: 0x00158FE0
			// (set) Token: 0x06004C28 RID: 19496 RVA: 0x0001C251 File Offset: 0x0001A451
			public unsafe int BVKNVuXycMBlctWTILPMCMsEYBt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt)) = value;
				}
			}

			// Token: 0x170017E4 RID: 6116
			// (get) Token: 0x06004C29 RID: 19497 RVA: 0x0015AE08 File Offset: 0x00159008
			// (set) Token: 0x06004C2A RID: 19498 RVA: 0x0001C26C File Offset: 0x0001A46C
			public unsafe int oQFakviQAOBxaHrLCZZBTGIJtuR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR)) = value;
				}
			}

			// Token: 0x170017E5 RID: 6117
			// (get) Token: 0x06004C2B RID: 19499 RVA: 0x0015AE30 File Offset: 0x00159030
			// (set) Token: 0x06004C2C RID: 19500 RVA: 0x0001C287 File Offset: 0x0001A487
			public unsafe float ibvCyMefpddmFeLLhWFZEVcGhrKu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PS4InputSource.iKfKRUNmwsuSkTeodPZvrFyyZZO.NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu)) = value;
				}
			}

			// Token: 0x04003D68 RID: 15720
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D69 RID: 15721
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D6A RID: 15722
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D6B RID: 15723
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D6C RID: 15724
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D6D RID: 15725
			private static readonly IntPtr NativeFieldInfoPtr_bBEzdgoNfdcKjGITcYtpxUysZxH;

			// Token: 0x04003D6E RID: 15726
			private static readonly IntPtr NativeFieldInfoPtr_AAhMvogABXMcIYmCDhiRnouGqFA;

			// Token: 0x04003D6F RID: 15727
			private static readonly IntPtr NativeFieldInfoPtr_oKXebCllqksgncucZdWWvDaypsz;

			// Token: 0x04003D70 RID: 15728
			private static readonly IntPtr NativeFieldInfoPtr_PSVHoCiIoVzUinjYxIxmaGCxuwA;

			// Token: 0x04003D71 RID: 15729
			private static readonly IntPtr NativeFieldInfoPtr_wALaxoadcbzCdqyLfHBRcaIqAseA;

			// Token: 0x04003D72 RID: 15730
			private static readonly IntPtr NativeFieldInfoPtr_phNPjhUkLMBADpEAbGabYcbZWwM;

			// Token: 0x04003D73 RID: 15731
			private static readonly IntPtr NativeFieldInfoPtr_FvSYthLIDogxqHWFRUVctEAQkehU;

			// Token: 0x04003D74 RID: 15732
			private static readonly IntPtr NativeFieldInfoPtr_PjCWxdWeCARHLBQcUGpEHCmLMVcJ;

			// Token: 0x04003D75 RID: 15733
			private static readonly IntPtr NativeFieldInfoPtr_BVKNVuXycMBlctWTILPMCMsEYBt;

			// Token: 0x04003D76 RID: 15734
			private static readonly IntPtr NativeFieldInfoPtr_oQFakviQAOBxaHrLCZZBTGIJtuR;

			// Token: 0x04003D77 RID: 15735
			private static readonly IntPtr NativeFieldInfoPtr_ibvCyMefpddmFeLLhWFZEVcGhrKu;

			// Token: 0x04003D78 RID: 15736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;
		}

		// Token: 0x02000392 RID: 914
		public class bvFfnzIqGECVobiSsOStWRisNUS : PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg
		{
			// Token: 0x06004C2D RID: 19501 RVA: 0x0015AE58 File Offset: 0x00159058
			// Note: this type is marked as 'beforefieldinit'.
			static bvFfnzIqGECVobiSsOStWRisNUS()
			{
				Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "bvFfnzIqGECVobiSsOStWRisNUS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr);
				PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr, 100673401);
				PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr, 100673402);
				PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_ControllerType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr, 100673403);
			}

			// Token: 0x06004C2E RID: 19502 RVA: 0x0015AEC0 File Offset: 0x001590C0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 310580, RefRangeEnd = 310585, XrefRangeStart = 310576, XrefRangeEnd = 310580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bvFfnzIqGECVobiSsOStWRisNUS(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType controllerType, string name, int playerId, int unityJoystickId, int handle, PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.XxiUOabMRIxtVIZMXEYmPJEBKwl capabilities)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref controllerType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capabilities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C2F RID: 19503 RVA: 0x0015AF58 File Offset: 0x00159158
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310590, RefRangeEnd = 310591, XrefRangeStart = 310585, XrefRangeEnd = 310590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS dSubCKSikOaufAaxCnPWeKqiPeHk(int A_0, int A_1, int A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>(intPtr3) : null;
			}

			// Token: 0x06004C30 RID: 19504 RVA: 0x0015AFB4 File Offset: 0x001591B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310616, RefRangeEnd = 310617, XrefRangeStart = 310591, XrefRangeEnd = 310616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS dSubCKSikOaufAaxCnPWeKqiPeHk(PS4InputSource.LyCIqIDJtLWQqrFEYaPMYMsNSIg.ControllerType A_0, int A_1, int A_2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_ControllerType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS>(intPtr3) : null;
			}

			// Token: 0x06004C31 RID: 19505 RVA: 0x0001C2A2 File Offset: 0x0001A4A2
			public bvFfnzIqGECVobiSsOStWRisNUS(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003D79 RID: 15737
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ControllerType_String_Int32_Int32_Int32_XxiUOabMRIxtVIZMXEYmPJEBKwl_0;

			// Token: 0x04003D7A RID: 15738
			private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_Int32_Int32_Int32_0;

			// Token: 0x04003D7B RID: 15739
			private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Public_Static_bvFfnzIqGECVobiSsOStWRisNUS_ControllerType_Int32_Int32_0;
		}

		// Token: 0x02000393 RID: 915
		public sealed class tffUJzVqaIGnFtVmyFTiyzYfDch : PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS
		{
			// Token: 0x06004C32 RID: 19506 RVA: 0x0015B010 File Offset: 0x00159210
			// Note: this type is marked as 'beforefieldinit'.
			static tffUJzVqaIGnFtVmyFTiyzYfDch()
			{
				Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "tffUJzVqaIGnFtVmyFTiyzYfDch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr);
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, 100673404);
				PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr, 100673405);
			}

			// Token: 0x06004C33 RID: 19507 RVA: 0x0015B0C8 File Offset: 0x001592C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310617, XrefRangeEnd = 310625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe tffUJzVqaIGnFtVmyFTiyzYfDch(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C34 RID: 19508 RVA: 0x0015B140 File Offset: 0x00159340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310625, XrefRangeEnd = 310644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C35 RID: 19509 RVA: 0x0001C2AB File Offset: 0x0001A4AB
			public tffUJzVqaIGnFtVmyFTiyzYfDch(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017E6 RID: 6118
			// (get) Token: 0x06004C36 RID: 19510 RVA: 0x0015B174 File Offset: 0x00159374
			// (set) Token: 0x06004C37 RID: 19511 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017E7 RID: 6119
			// (get) Token: 0x06004C38 RID: 19512 RVA: 0x0015B190 File Offset: 0x00159390
			// (set) Token: 0x06004C39 RID: 19513 RVA: 0x0001C2C2 File Offset: 0x0001A4C2
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017E8 RID: 6120
			// (get) Token: 0x06004C3A RID: 19514 RVA: 0x0015B1AC File Offset: 0x001593AC
			// (set) Token: 0x06004C3B RID: 19515 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017E9 RID: 6121
			// (get) Token: 0x06004C3C RID: 19516 RVA: 0x0015B1C8 File Offset: 0x001593C8
			// (set) Token: 0x06004C3D RID: 19517 RVA: 0x0001C2DE File Offset: 0x0001A4DE
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017EA RID: 6122
			// (get) Token: 0x06004C3E RID: 19518 RVA: 0x0015B1E4 File Offset: 0x001593E4
			// (set) Token: 0x06004C3F RID: 19519 RVA: 0x0001C2EC File Offset: 0x0001A4EC
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.tffUJzVqaIGnFtVmyFTiyzYfDch.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x04003D7C RID: 15740
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D7D RID: 15741
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D7E RID: 15742
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D7F RID: 15743
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D80 RID: 15744
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D81 RID: 15745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

			// Token: 0x04003D82 RID: 15746
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0;
		}

		// Token: 0x02000394 RID: 916
		public sealed class CqYGYCapCNNBIiiZbThJgFSdfoPH : PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS
		{
			// Token: 0x06004C40 RID: 19520 RVA: 0x0015B200 File Offset: 0x00159400
			// Note: this type is marked as 'beforefieldinit'.
			static CqYGYCapCNNBIiiZbThJgFSdfoPH()
			{
				Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "CqYGYCapCNNBIiiZbThJgFSdfoPH");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr);
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, 100673406);
				PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr, 100673407);
			}

			// Token: 0x06004C41 RID: 19521 RVA: 0x0015B2B8 File Offset: 0x001594B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310644, XrefRangeEnd = 310652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CqYGYCapCNNBIiiZbThJgFSdfoPH(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C42 RID: 19522 RVA: 0x0015B330 File Offset: 0x00159530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310652, XrefRangeEnd = 310667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C43 RID: 19523 RVA: 0x0001C2FA File Offset: 0x0001A4FA
			public CqYGYCapCNNBIiiZbThJgFSdfoPH(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017EB RID: 6123
			// (get) Token: 0x06004C44 RID: 19524 RVA: 0x0015B364 File Offset: 0x00159564
			// (set) Token: 0x06004C45 RID: 19525 RVA: 0x0001C303 File Offset: 0x0001A503
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017EC RID: 6124
			// (get) Token: 0x06004C46 RID: 19526 RVA: 0x0015B380 File Offset: 0x00159580
			// (set) Token: 0x06004C47 RID: 19527 RVA: 0x0001C311 File Offset: 0x0001A511
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017ED RID: 6125
			// (get) Token: 0x06004C48 RID: 19528 RVA: 0x0015B39C File Offset: 0x0015959C
			// (set) Token: 0x06004C49 RID: 19529 RVA: 0x0001C31F File Offset: 0x0001A51F
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017EE RID: 6126
			// (get) Token: 0x06004C4A RID: 19530 RVA: 0x0015B3B8 File Offset: 0x001595B8
			// (set) Token: 0x06004C4B RID: 19531 RVA: 0x0001C32D File Offset: 0x0001A52D
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017EF RID: 6127
			// (get) Token: 0x06004C4C RID: 19532 RVA: 0x0015B3D4 File Offset: 0x001595D4
			// (set) Token: 0x06004C4D RID: 19533 RVA: 0x0001C33B File Offset: 0x0001A53B
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.CqYGYCapCNNBIiiZbThJgFSdfoPH.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x04003D83 RID: 15747
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D84 RID: 15748
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D85 RID: 15749
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D86 RID: 15750
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D87 RID: 15751
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D88 RID: 15752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

			// Token: 0x04003D89 RID: 15753
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0;
		}

		// Token: 0x02000395 RID: 917
		public sealed class IVVtVXZyTZLeJMDMLIzLPmOYzva : PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS
		{
			// Token: 0x06004C4E RID: 19534 RVA: 0x0015B3F0 File Offset: 0x001595F0
			// Note: this type is marked as 'beforefieldinit'.
			static IVVtVXZyTZLeJMDMLIzLPmOYzva()
			{
				Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "IVVtVXZyTZLeJMDMLIzLPmOYzva");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr);
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, 100673408);
				PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr, 100673409);
			}

			// Token: 0x06004C4F RID: 19535 RVA: 0x0015B4A8 File Offset: 0x001596A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310667, XrefRangeEnd = 310675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IVVtVXZyTZLeJMDMLIzLPmOYzva(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C50 RID: 19536 RVA: 0x0015B520 File Offset: 0x00159720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310675, XrefRangeEnd = 310694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C51 RID: 19537 RVA: 0x0001C349 File Offset: 0x0001A549
			public IVVtVXZyTZLeJMDMLIzLPmOYzva(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017F0 RID: 6128
			// (get) Token: 0x06004C52 RID: 19538 RVA: 0x0015B554 File Offset: 0x00159754
			// (set) Token: 0x06004C53 RID: 19539 RVA: 0x0001C352 File Offset: 0x0001A552
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017F1 RID: 6129
			// (get) Token: 0x06004C54 RID: 19540 RVA: 0x0015B570 File Offset: 0x00159770
			// (set) Token: 0x06004C55 RID: 19541 RVA: 0x0001C360 File Offset: 0x0001A560
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017F2 RID: 6130
			// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0015B58C File Offset: 0x0015978C
			// (set) Token: 0x06004C57 RID: 19543 RVA: 0x0001C36E File Offset: 0x0001A56E
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017F3 RID: 6131
			// (get) Token: 0x06004C58 RID: 19544 RVA: 0x0015B5A8 File Offset: 0x001597A8
			// (set) Token: 0x06004C59 RID: 19545 RVA: 0x0001C37C File Offset: 0x0001A57C
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017F4 RID: 6132
			// (get) Token: 0x06004C5A RID: 19546 RVA: 0x0015B5C4 File Offset: 0x001597C4
			// (set) Token: 0x06004C5B RID: 19547 RVA: 0x0001C38A File Offset: 0x0001A58A
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.IVVtVXZyTZLeJMDMLIzLPmOYzva.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x04003D8A RID: 15754
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D8B RID: 15755
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D8C RID: 15756
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D8D RID: 15757
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D8E RID: 15758
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D8F RID: 15759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

			// Token: 0x04003D90 RID: 15760
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0;
		}

		// Token: 0x02000396 RID: 918
		public sealed class AdkSGHxyhTVzFtJPWfDmyRteARA : PS4InputSource.bvFfnzIqGECVobiSsOStWRisNUS
		{
			// Token: 0x06004C5C RID: 19548 RVA: 0x0015B5E0 File Offset: 0x001597E0
			// Note: this type is marked as 'beforefieldinit'.
			static AdkSGHxyhTVzFtJPWfDmyRteARA()
			{
				Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PS4InputSource>.NativeClassPtr, "AdkSGHxyhTVzFtJPWfDmyRteARA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr);
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, "NePfDjfPzaSErCqurMPkukIdUVA");
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, "ZpmjzRIHajVhBOhKOkCwdxHNdoK");
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, "jkOgZDusSliDKQqFUxSzGYTCEaj");
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, 100673410);
				PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr, 100673411);
			}

			// Token: 0x06004C5D RID: 19549 RVA: 0x0015B698 File Offset: 0x00159898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310694, XrefRangeEnd = 310702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdkSGHxyhTVzFtJPWfDmyRteARA(string name, int playerId, int unityJoystickId, int handle)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C5E RID: 19550 RVA: 0x0015B710 File Offset: 0x00159910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310702, XrefRangeEnd = 310727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DnabcPODSpXDbAUSZtdTqmngbzL()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C5F RID: 19551 RVA: 0x0001C398 File Offset: 0x0001A598
			public AdkSGHxyhTVzFtJPWfDmyRteARA(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017F5 RID: 6133
			// (get) Token: 0x06004C60 RID: 19552 RVA: 0x0015B744 File Offset: 0x00159944
			// (set) Token: 0x06004C61 RID: 19553 RVA: 0x0001C3A1 File Offset: 0x0001A5A1
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170017F6 RID: 6134
			// (get) Token: 0x06004C62 RID: 19554 RVA: 0x0015B760 File Offset: 0x00159960
			// (set) Token: 0x06004C63 RID: 19555 RVA: 0x0001C3AF File Offset: 0x0001A5AF
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170017F7 RID: 6135
			// (get) Token: 0x06004C64 RID: 19556 RVA: 0x0015B77C File Offset: 0x0015997C
			// (set) Token: 0x06004C65 RID: 19557 RVA: 0x0001C3BD File Offset: 0x0001A5BD
			public unsafe static float NePfDjfPzaSErCqurMPkukIdUVA
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA, (void*)(&value));
				}
			}

			// Token: 0x170017F8 RID: 6136
			// (get) Token: 0x06004C66 RID: 19558 RVA: 0x0015B798 File Offset: 0x00159998
			// (set) Token: 0x06004C67 RID: 19559 RVA: 0x0001C3CB File Offset: 0x0001A5CB
			public unsafe static int ZpmjzRIHajVhBOhKOkCwdxHNdoK
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK, (void*)(&value));
				}
			}

			// Token: 0x170017F9 RID: 6137
			// (get) Token: 0x06004C68 RID: 19560 RVA: 0x0015B7B4 File Offset: 0x001599B4
			// (set) Token: 0x06004C69 RID: 19561 RVA: 0x0001C3D9 File Offset: 0x0001A5D9
			public unsafe static int jkOgZDusSliDKQqFUxSzGYTCEaj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PS4InputSource.AdkSGHxyhTVzFtJPWfDmyRteARA.NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj, (void*)(&value));
				}
			}

			// Token: 0x04003D91 RID: 15761
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04003D92 RID: 15762
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04003D93 RID: 15763
			private static readonly IntPtr NativeFieldInfoPtr_NePfDjfPzaSErCqurMPkukIdUVA;

			// Token: 0x04003D94 RID: 15764
			private static readonly IntPtr NativeFieldInfoPtr_ZpmjzRIHajVhBOhKOkCwdxHNdoK;

			// Token: 0x04003D95 RID: 15765
			private static readonly IntPtr NativeFieldInfoPtr_jkOgZDusSliDKQqFUxSzGYTCEaj;

			// Token: 0x04003D96 RID: 15766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Int32_0;

			// Token: 0x04003D97 RID: 15767
			private static readonly IntPtr NativeMethodInfoPtr_DnabcPODSpXDbAUSZtdTqmngbzL_Protected_Virtual_Void_0;
		}
	}
}
