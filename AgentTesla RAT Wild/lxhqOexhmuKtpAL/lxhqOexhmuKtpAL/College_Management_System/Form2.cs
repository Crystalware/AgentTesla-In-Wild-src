using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public class Form12 : Form
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000E644 File Offset: 0x0000C844
		public Form12()
		{
			for (;;)
			{
				IL_100:
				int num = 13;
				int num2 = -31;
				for (;;)
				{
					num2 ^= 51;
					for (;;)
					{
						IL_45:
						int num3 = 7;
						int num4 = -25;
						for (;;)
						{
							num4 ^= 55;
							switch (num4 + 51)
							{
							case 0:
								goto IL_45;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.wsyoqrrjsoniuh()).MethodHandle;
								num4 = Form12.wsyoqrrjsoniul(51);
								continue;
							}
							case 2:
								switch (num3)
								{
								case 61:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.set_Label1(Label)).MethodHandle;
									num3 = 5;
									goto IL_22;
								}
								case 62:
									break;
								case 63:
									switch (num2 + 49)
									{
									case 0:
										switch (num)
										{
										case 50:
											num = 3;
											goto IL_11;
										case 51:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = 12;
											goto IL_11;
										case 52:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.get_cmdBack()).MethodHandle;
											num = 14;
											goto IL_11;
										}
										case 53:
											num = 2;
											goto IL_11;
										case 54:
											this.wsyoqrrjsoniuh();
											num = 8;
											goto IL_11;
										case 55:
											base.Load += this.wsyoqrrjsoniui;
											num = 15;
											goto IL_11;
										case 56:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = 9;
											goto IL_11;
										case 57:
											return;
										}
										goto Block_3;
									case 1:
										goto IL_ED;
									case 2:
										goto IL_100;
									case 3:
										break;
									default:
										num3 = 6;
										goto IL_22;
									}
									IL_11:
									num ^= 58;
									break;
								case 64:
									goto IL_B7;
								default:
									num4 = -6;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(42);
								num3 = 120;
								goto IL_22;
							case 3:
								goto IL_22;
							}
							IL_3B:
							num4 = Form12.wsyoqrrjsoniul(40);
							continue;
							IL_22:
							num3 ^= 56;
							goto IL_3B;
						}
					}
					IL_B7:
					continue;
					Block_3:
					num2 = -30;
					continue;
					IL_ED:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.wsyoqrrjsoniuk(object, EventArgs)).MethodHandle;
					num2 = Form12.wsyoqrrjsoniul(52);
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000E82C File Offset: 0x0000CA2C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_117:
						int num = 3;
						int num2 = -18;
						for (;;)
						{
							num2 ^= 62;
							for (;;)
							{
								IL_B0:
								int num3 = 13;
								int num4 = Form7.mqgfoefwabbyeu(24);
								for (;;)
								{
									num4 ^= 54;
									switch (num4 + 59)
									{
									case 0:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.get_txtStudents()).MethodHandle;
										num4 = -13;
										continue;
									}
									case 1:
										switch (num3)
										{
										case 59:
											break;
										case 60:
											switch (num2 + 51)
											{
											case 0:
												goto IL_104;
											case 1:
												goto IL_117;
											case 2:
												switch (num)
												{
												case 57:
													this.components.Dispose();
													num = 1;
													goto IL_3E;
												case 58:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.get_Label2()).MethodHandle;
													num = 0;
													goto IL_3E;
												}
												case 59:
													num = 6;
													goto IL_3E;
												case 60:
													goto IL_197;
												}
												goto Block_6;
											case 3:
												break;
											default:
												num3 = 10;
												goto IL_4F;
											}
											IL_3E:
											num ^= 58;
											break;
										case 61:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.get_Label1()).MethodHandle;
											num3 = 12;
											goto IL_4F;
										}
										case 62:
											goto IL_FF;
										default:
											num4 = -15;
											continue;
										}
										num2 = Form7.mqgfoefwabbyeu(23);
										num3 = 15;
										break;
									case 2:
										goto IL_B0;
									case 3:
										break;
									default:
										IL_7A:
										num4 = Form7.mqgfoefwabbyeu(19);
										continue;
									}
									IL_4F:
									num3 ^= 49;
									goto IL_7A;
								}
							}
							IL_FF:
							continue;
							IL_104:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.set_Label2(Label)).MethodHandle;
							num2 = Form7.mqgfoefwabbyeu(21);
							continue;
							Block_6:
							num2 = -16;
						}
					}
					IL_197:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		[DebuggerStepThrough]
		private void wsyoqrrjsoniuh()
		{
			for (;;)
			{
				int num = 120;
				for (;;)
				{
					num ^= 52;
					switch (num)
					{
					case 54:
						this.Label4.Margin = new Padding(4, 0, 4, 0);
						for (;;)
						{
							int num2 = Form10.pdqangwdsoatqb(72);
							for (;;)
							{
								num2 ^= 67;
								switch (num2 + 60)
								{
								case 0:
									this.Label4.Name = "Label4";
									num2 = -117;
									continue;
								case 1:
									this.Label4.Text = "Adm No.";
									num2 = -124;
									continue;
								case 2:
									num2 = -122;
									continue;
								case 3:
									num2 = -113;
									continue;
								case 4:
									num2 = -115;
									continue;
								case 5:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.get_txtAdmNo2()).MethodHandle;
									num2 = -118;
									continue;
								}
								case 6:
									num2 = -116;
									continue;
								case 7:
									num2 = -121;
									continue;
								case 8:
									this.txtStudents.Location = new Point(295, 164);
									num2 = -119;
									continue;
								case 9:
									num2 = -109;
									continue;
								case 10:
									this.Label4.Size = new Size(62, 17);
									num2 = -114;
									continue;
								case 11:
									num = 117;
									num2 = -110;
									continue;
								case 12:
									this.Label4.TabIndex = 25;
									num2 = Form10.pdqangwdsoatqb(66);
									continue;
								case 13:
									goto IL_110;
								}
								break;
							}
						}
						IL_110:
						continue;
					case 55:
						base.ClientSize = new Size(607, 560);
						base.Controls.Add(this.cmdBack);
						base.Controls.Add(this.txtName3);
						base.Controls.Add(this.txtName2);
						base.Controls.Add(this.txtAdmNo3);
						base.Controls.Add(this.txtAdmNo2);
						num = 127;
						continue;
					case 56:
					{
						RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.set_Label5(Label)).MethodHandle;
						num = 12;
						continue;
					}
					case 57:
						this.cmdView.TabIndex = 22;
						this.cmdView.Text = "VIEW STUDENTS";
						this.cmdView.UseVisualStyleBackColor = false;
						this.lblSchool.AutoSize = true;
						this.lblSchool.ForeColor = Color.White;
						this.lblSchool.Location = new Point(137, 95);
						num = 115;
						continue;
					case 58:
						this.lblSchool = new Label();
						this.Label2 = new Label();
						this.Label1 = new Label();
						base.SuspendLayout();
						this.cmdBack.BackColor = Color.BlueViolet;
						this.cmdBack.ForeColor = Color.White;
						num = 116;
						continue;
					case 59:
						this.Label2.Text = "School:";
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(237, 34);
						this.Label1.Margin = new Padding(4, 0, 4, 0);
						this.Label1.Name = "Label1";
						num = 112;
						continue;
					case 60:
						this.txtAdmNo = new TextBox();
						this.Label5 = new Label();
						this.Label4 = new Label();
						this.txtStudents = new TextBox();
						this.Label3 = new Label();
						this.cmdView = new Button();
						num = 14;
						continue;
					case 61:
						this.txtAdmNo2.TabIndex = 29;
						for (;;)
						{
							int num3 = 10;
							for (;;)
							{
								switch (num3 ^ 70)
								{
								case 71:
									num3 = 20;
									continue;
								case 72:
									this.txtName.Location = new Point(213, 326);
									num3 = 12;
									continue;
								case 73:
									num3 = 22;
									continue;
								case 74:
									num3 = 11;
									continue;
								case 75:
									this.txtName.Name = "txtName";
									num3 = 1;
									continue;
								case 76:
									num3 = 14;
									continue;
								case 77:
									this.txtName.Margin = new Padding(4, 4, 4, 4);
									num3 = 15;
									continue;
								case 78:
									num3 = 23;
									continue;
								case 79:
									num3 = 13;
									continue;
								case 80:
									this.txtName.Multiline = true;
									num3 = 9;
									continue;
								case 81:
									num = 124;
									num3 = 18;
									continue;
								case 82:
									this.txtName.Size = new Size(348, 36);
									num3 = 8;
									continue;
								case 83:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.get_txtAdmNo()).MethodHandle;
									num3 = 21;
									continue;
								}
								case 84:
									goto IL_443;
								}
								break;
							}
						}
						IL_443:
						continue;
					case 62:
						base.Controls.Add(this.cmdView);
						for (;;)
						{
							int num4 = Form6.sbdifomqugmuko(64);
							for (;;)
							{
								num4 ^= 57;
								switch (num4 + 53)
								{
								case 0:
									base.Controls.Add(this.Label1);
									num4 = Form7.mqgfoefwabbyeu(27);
									continue;
								case 1:
									num4 = -24;
									continue;
								case 2:
									num = 123;
									num4 = -31;
									continue;
								case 3:
									base.Controls.Add(this.Label2);
									num4 = -21;
									continue;
								case 4:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.set_txtAdmNo(TextBox)).MethodHandle;
									num4 = -10;
									continue;
								}
								case 5:
									num4 = -12;
									continue;
								case 6:
									this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
									num4 = -17;
									continue;
								case 7:
									num4 = -14;
									continue;
								case 8:
									base.Margin = new Padding(4, 4, 4, 4);
									num4 = -23;
									continue;
								case 9:
									base.Controls.Add(this.lblSchool);
									num4 = -18;
									continue;
								case 10:
									num4 = -19;
									continue;
								case 11:
									num4 = -22;
									continue;
								case 12:
									num4 = -9;
									continue;
								case 13:
									goto IL_578;
								}
								break;
							}
						}
						IL_578:
						continue;
					case 63:
						this.cmdView.BackColor = Color.BlueViolet;
						this.cmdView.ForeColor = Color.White;
						this.cmdView.Location = new Point(213, 215);
						this.cmdView.Margin = new Padding(4, 4, 4, 4);
						this.cmdView.Name = "cmdView";
						this.cmdView.Size = new Size(181, 37);
						num = 13;
						continue;
					case 64:
						this.cmdBack.Location = new Point(217, 482);
						this.cmdBack.Margin = new Padding(4, 4, 4, 4);
						this.cmdBack.Name = "cmdBack";
						this.cmdBack.Size = new Size(211, 42);
						this.cmdBack.TabIndex = 33;
						this.cmdBack.Text = "GO BACK";
						num = 121;
						continue;
					case 65:
						this.txtStudents.Margin = new Padding(4, 4, 4, 4);
						this.txtStudents.Name = "txtStudents";
						this.txtStudents.Size = new Size(132, 23);
						this.txtStudents.TabIndex = 24;
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						num = 114;
						continue;
					case 66:
						this.Label2.ForeColor = Color.White;
						this.Label2.Location = new Point(43, 95);
						this.Label2.Margin = new Padding(4, 0, 4, 0);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(55, 17);
						this.Label2.TabIndex = 20;
						num = 15;
						continue;
					case 67:
						this.txtName2.TabIndex = 31;
						this.txtAdmNo3.Location = new Point(47, 415);
						this.txtAdmNo3.Margin = new Padding(4, 4, 4, 4);
						this.txtAdmNo3.Multiline = true;
						this.txtAdmNo3.Name = "txtAdmNo3";
						this.txtAdmNo3.Size = new Size(157, 36);
						num = 113;
						continue;
					case 68:
						this.Label1.Size = new Size(134, 17);
						this.Label1.TabIndex = 19;
						this.Label1.Text = "Lecturer's Schedule";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						num = 3;
						continue;
					case 69:
						this.txtAdmNo3.TabIndex = 30;
						this.txtAdmNo2.Location = new Point(47, 370);
						this.txtAdmNo2.Margin = new Padding(4, 4, 4, 4);
						this.txtAdmNo2.Multiline = true;
						this.txtAdmNo2.Name = "txtAdmNo2";
						this.txtAdmNo2.Size = new Size(157, 36);
						num = 9;
						continue;
					case 70:
						this.Label3.Location = new Point(43, 164);
						this.Label3.Margin = new Padding(4, 0, 4, 0);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(183, 17);
						this.Label3.TabIndex = 23;
						this.Label3.Text = "No. of Students Registered:";
						num = 11;
						continue;
					case 71:
						this.lblSchool.Margin = new Padding(4, 0, 4, 0);
						this.lblSchool.Name = "lblSchool";
						this.lblSchool.Size = new Size(51, 17);
						this.lblSchool.TabIndex = 21;
						this.lblSchool.Text = "Label3";
						this.Label2.AutoSize = true;
						num = 118;
						continue;
					case 72:
						this.txtName.TabIndex = 28;
						this.txtAdmNo.Location = new Point(47, 326);
						this.txtAdmNo.Margin = new Padding(4, 4, 4, 4);
						this.txtAdmNo.Multiline = true;
						this.txtAdmNo.Name = "txtAdmNo";
						this.txtAdmNo.Size = new Size(157, 36);
						num = 125;
						continue;
					case 73:
						this.txtAdmNo.TabIndex = 27;
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(209, 287);
						this.Label5.Margin = new Padding(4, 0, 4, 0);
						this.Label5.Name = "Label5";
						num = 126;
						continue;
					case 74:
						this.Label5.Size = new Size(108, 17);
						this.Label5.TabIndex = 26;
						this.Label5.Text = "Student's Name";
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(47, 287);
						num = 2;
						continue;
					case 75:
						base.Controls.Add(this.txtName);
						base.Controls.Add(this.txtAdmNo);
						base.Controls.Add(this.Label5);
						base.Controls.Add(this.Label4);
						base.Controls.Add(this.txtStudents);
						base.Controls.Add(this.Label3);
						num = 10;
						continue;
					case 76:
						this.cmdBack = new Button();
						this.txtName3 = new TextBox();
						this.txtName2 = new TextBox();
						this.txtAdmNo3 = new TextBox();
						this.txtAdmNo2 = new TextBox();
						this.txtName = new TextBox();
						num = 8;
						continue;
					case 77:
						this.cmdBack.UseVisualStyleBackColor = false;
						this.txtName3.Location = new Point(213, 415);
						this.txtName3.Margin = new Padding(4, 4, 4, 4);
						this.txtName3.Multiline = true;
						this.txtName3.Name = "txtName3";
						this.txtName3.Size = new Size(348, 36);
						num = 122;
						continue;
					case 78:
						this.txtName3.TabIndex = 32;
						this.txtName2.Location = new Point(213, 370);
						this.txtName2.Margin = new Padding(4, 4, 4, 4);
						this.txtName2.Multiline = true;
						this.txtName2.Name = "txtName2";
						this.txtName2.Size = new Size(348, 36);
						num = 119;
						continue;
					case 79:
						goto IL_CC8;
					}
					break;
				}
			}
			IL_CC8:
			base.Name = "Form12";
			this.Text = "Form12";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		internal virtual Button cmdBack
		{
			[CompilerGenerated]
			get
			{
				return this._cmdBack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.wsyoqrrjsoniuk);
				Button cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click -= value2;
				}
				this._cmdBack = value;
				cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click += value2;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000F83B File Offset: 0x0000DA3B
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000F849 File Offset: 0x0000DA49
		internal virtual TextBox txtName3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000F856 File Offset: 0x0000DA56
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000F864 File Offset: 0x0000DA64
		internal virtual TextBox txtName2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000F871 File Offset: 0x0000DA71
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000F87F File Offset: 0x0000DA7F
		internal virtual TextBox txtAdmNo3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000F88C File Offset: 0x0000DA8C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000F89A File Offset: 0x0000DA9A
		internal virtual TextBox txtAdmNo2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000F8A7 File Offset: 0x0000DAA7
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000F8B5 File Offset: 0x0000DAB5
		internal virtual TextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000F8C2 File Offset: 0x0000DAC2
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		internal virtual TextBox txtAdmNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000F8DD File Offset: 0x0000DADD
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000F8EB File Offset: 0x0000DAEB
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000F906 File Offset: 0x0000DB06
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000F913 File Offset: 0x0000DB13
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000F921 File Offset: 0x0000DB21
		internal virtual TextBox txtStudents { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000F92E File Offset: 0x0000DB2E
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000F93C File Offset: 0x0000DB3C
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000F949 File Offset: 0x0000DB49
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000F958 File Offset: 0x0000DB58
		internal virtual Button cmdView
		{
			[CompilerGenerated]
			get
			{
				return this._cmdView;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.wsyoqrrjsoniuj);
				Button cmdView = this._cmdView;
				if (cmdView != null)
				{
					cmdView.Click -= value2;
				}
				this._cmdView = value;
				cmdView = this._cmdView;
				if (cmdView != null)
				{
					cmdView.Click += value2;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000F9C3 File Offset: 0x0000DBC3
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000F9D1 File Offset: 0x0000DBD1
		internal virtual Label lblSchool { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000F9DE File Offset: 0x0000DBDE
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000F9F9 File Offset: 0x0000DBF9
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000FA07 File Offset: 0x0000DC07
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000108 RID: 264 RVA: 0x0000FA14 File Offset: 0x0000DC14
		private void wsyoqrrjsoniui(object bc, EventArgs bd)
		{
			int num2;
			for (;;)
			{
				int num = 0;
				for (;;)
				{
					switch (num ^ 66)
					{
					case 65:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.set_cmdView(Button)).MethodHandle;
						num = 3;
						continue;
					}
					case 66:
						num2 = 0;
						num = 8;
						continue;
					case 67:
						this.rs.Open("Select School from LecturersProfile where LecturerID = '" + yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxi.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
						num = 6;
						continue;
					case 68:
						num = 7;
						continue;
					case 69:
						this.lblSchool.Text = Conversions.ToString(this.rs.Fields["School"].Value);
						num = 11;
						continue;
					case 70:
					{
						bool flag = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["School"].Value, "Science, Engineering and Health", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text, "Applied Computer Science", false) == 0));
						num = 10;
						continue;
					}
					case 71:
						num = 1;
						continue;
					case 72:
					{
						bool flag;
						if (flag)
						{
							num = 9;
							continue;
						}
						goto IL_154;
					}
					case 73:
						num = 4;
						continue;
					case 74:
						this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
						num = 5;
						continue;
					case 75:
						goto IL_151;
					}
					break;
				}
			}
			IL_151:
			bool flag2 = false;
			goto IL_157;
			IL_154:
			flag2 = true;
			IL_157:
			checked
			{
				if (!flag2)
				{
					num2++;
					for (;;)
					{
						int num3 = Form6.sbdifomqugmuko(67);
						for (;;)
						{
							num3 ^= 60;
							switch (unchecked(num3 + 70))
							{
							case 0:
								this.txtStudents.Text = Conversions.ToString(num2);
								num3 = -121;
								continue;
							case 1:
								num3 = -127;
								continue;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.wsyoqrrjsoniuj(object, EventArgs)).MethodHandle;
								num3 = Form10.pdqangwdsoatqb(70);
								continue;
							}
							case 3:
								num3 = -126;
								continue;
							case 4:
								goto IL_1C8;
							}
							break;
						}
					}
					IL_1C8:;
				}
				else
				{
					bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["School"].Value, "Science, Engineering and Health", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text, "Electrical Engineering", false) == 0));
					if (flag3)
					{
						num2++;
						for (;;)
						{
							int num4 = 9;
							for (;;)
							{
								switch (num4 ^ 72)
								{
								case 63:
									this.txtStudents.Text = Conversions.ToString(num2);
									num4 = 11;
									continue;
								case 64:
									num4 = 13;
									continue;
								case 65:
									this.txtStudents.Text = Conversions.ToString(num2);
									num4 = 10;
									continue;
								case 66:
									num4 = 119;
									continue;
								case 67:
									num4 = 8;
									continue;
								case 68:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.set_txtAdmNo2(TextBox)).MethodHandle;
									num4 = 12;
									continue;
								}
								case 69:
									goto IL_2BC;
								}
								break;
							}
						}
						IL_2BC:;
					}
					else
					{
						bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["School"].Value, "Communication, Language and Performing Arts", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text, "Communication", false) == 0));
						if (flag4)
						{
							num2++;
							for (;;)
							{
								int num5 = Form10.pdqangwdsoatqb(66);
								for (;;)
								{
									num5 ^= 68;
									switch (unchecked(num5 + 65))
									{
									case 0:
									{
										RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.wsyoqrrjsoniuj(object, EventArgs)).MethodHandle;
										num5 = -5;
										continue;
									}
									case 1:
										num5 = -122;
										continue;
									case 2:
										this.txtStudents.Text = Conversions.ToString(num2);
										num5 = -124;
										continue;
									case 3:
										num5 = -121;
										continue;
									case 4:
										goto IL_38A;
									}
									break;
								}
							}
							IL_38A:;
						}
						else
						{
							bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["School"].Value, "Arts and Humanities", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text, "International Relations", false) == 0));
							if (flag5)
							{
								num2++;
								this.txtStudents.Text = Conversions.ToString(num2);
							}
							else
							{
								bool flag6 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.rs.Fields["School"].Value, "Business and Economics", false), Operators.CompareString(yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text, "Economics", false) == 0));
								if (flag6)
								{
									num2++;
									this.txtStudents.Text = Conversions.ToString(num2);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000FF00 File Offset: 0x0000E100
		private void wsyoqrrjsoniuj(object be, EventArgs bf)
		{
			bool flag = Operators.CompareString(this.txtStudents.Text, "", false) == 0;
			if (flag)
			{
				Interaction.MsgBox("No Student(s) Registered.", MsgBoxStyle.Information, null);
			}
			else
			{
				for (;;)
				{
					IL_158:
					int num = 25;
					int num2 = -24;
					for (;;)
					{
						num2 ^= 81;
						for (;;)
						{
							IL_B5:
							int num3 = Form12.wsyoqrrjsoniul(40);
							int num4 = -5;
							for (;;)
							{
								num4 ^= 72;
								switch (num4 + 80)
								{
								case 0:
									switch (num3 + 76)
									{
									case 0:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.set_txtAdmNo2(TextBox)).MethodHandle;
										num3 = Form12.wsyoqrrjsoniul(51);
										goto IL_60;
									}
									case 1:
										switch (num2 + 74)
										{
										case 0:
											switch (num)
											{
											case 80:
												this.rs.Close();
												num = 31;
												goto IL_4F;
											case 81:
												num = 27;
												goto IL_4F;
											case 82:
												this.txtAdmNo.Text = Conversions.ToString(this.rs.Fields["AdmNo"].Value);
												num = 29;
												goto IL_4F;
											case 83:
												num = 16;
												goto IL_4F;
											case 84:
												num = 17;
												goto IL_4F;
											case 85:
											{
												RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.wsyoqrrjsoniui(object, EventArgs)).MethodHandle;
												num = 28;
												goto IL_4F;
											}
											case 86:
												num = 30;
												goto IL_4F;
											case 87:
												this.rs.Open("Select AdmNo, FirstName, LastName from StudentsProfile where Program = '" + yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.lblProgram.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
												num = 24;
												goto IL_4F;
											case 88:
												this.txtName.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(this.rs.Fields["LastName"].Value, ", "), this.rs.Fields["FirstName"].Value));
												num = 26;
												goto IL_4F;
											case 89:
												goto IL_2AC;
											}
											goto Block_4;
										case 1:
											goto IL_158;
										case 2:
											goto IL_163;
										case 3:
											break;
										default:
											num3 = -5;
											goto IL_60;
										}
										IL_4F:
										num ^= 73;
										break;
									case 2:
										break;
									case 3:
										goto IL_115;
									default:
										num4 = -7;
										continue;
									}
									num2 = Form2.uwpnsrqhswlmjh(50);
									num3 = -6;
									break;
								case 1:
									goto IL_B5;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.Dispose(bool)).MethodHandle;
									num4 = -6;
									continue;
								}
								case 3:
									break;
								default:
									IL_8B:
									num4 = Form12.wsyoqrrjsoniul(40);
									continue;
								}
								IL_60:
								num3 ^= 77;
								goto IL_8B;
							}
						}
						IL_115:
						continue;
						Block_4:
						num2 = Form12.wsyoqrrjsoniul(49);
						continue;
						IL_163:
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.get_txtName2()).MethodHandle;
						num2 = -23;
					}
				}
				IL_2AC:;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000101BC File Offset: 0x0000E3BC
		private void wsyoqrrjsoniuk(object bg, EventArgs bh)
		{
			for (;;)
			{
				IL_DB:
				int num = Form7.mqgfoefwabbyeu(19);
				int num2 = -15;
				for (;;)
				{
					num2 ^= 70;
					for (;;)
					{
						IL_3C:
						int num3 = 12;
						int num4 = -10;
						for (;;)
						{
							num4 ^= 74;
							switch (num4 + 71)
							{
							case 0:
								goto IL_3C;
							case 1:
								switch (num3)
								{
								case 70:
									break;
								case 71:
									switch (num2 + 76)
									{
									case 0:
										goto IL_A4;
									case 1:
										switch (num + 76)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form12.set_cmdView(Button)).MethodHandle;
											num = -14;
											goto IL_0B;
										}
										case 1:
											num = -1;
											goto IL_0B;
										case 2:
											base.Hide();
											num = -15;
											goto IL_0B;
										case 3:
											num = Form7.mqgfoefwabbyeu(24);
											goto IL_0B;
										case 4:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxg.Show();
											num = -13;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_2;
									case 2:
										goto IL_DB;
									case 3:
										break;
									default:
										num3 = 13;
										goto IL_19;
									}
									IL_0B:
									num ^= 70;
									break;
								case 72:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form12.get_txtAdmNo2()).MethodHandle;
									num3 = 3;
									goto IL_19;
								}
								case 73:
									goto IL_9F;
								default:
									num4 = Form7.mqgfoefwabbyeu(21);
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(21);
								num3 = 2;
								goto IL_19;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form12.set_txtName(TextBox)).MethodHandle;
								num4 = -15;
								continue;
							}
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form7.mqgfoefwabbyeu(19);
							continue;
							IL_19:
							num3 ^= 75;
							goto IL_32;
						}
					}
					IL_9F:
					continue;
					IL_A4:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form12.set_txtStudents(TextBox)).MethodHandle;
					num2 = -14;
					continue;
					Block_2:
					num2 = -16;
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001034C File Offset: 0x0000E54C
		internal static int wsyoqrrjsoniul(int bi)
		{
			switch (bi - ~(-(5248 >> 7)))
			{
			case 0:
				return (-907554205 ^ 624382475) - -321879952;
			case 1:
				return -557118117 - -557117733 >> 4;
			case 3:
				return ~(769204695 - 217305343 ^ 551899341);
			case 8:
				return ~(370768207 << 1) + 173773304 - -567763079;
			case 9:
				return --568662544 - 568662557 << 1;
			case 11:
				return -14 >> 1;
			case 12:
				return (84235311 ^ -84236881) >> 7;
			case 13:
				return ~(-((-877100109 ^ -340726428) + -537423679) >> 3);
			case 14:
				return ~(216 >> 3);
			case 16:
				return -(~(58890654 + 93064782 - 151955869) >> 4);
			case 18:
				return -(-109368712 + 109368724);
			}
			return (-102733045 ^ 102733035) >> 5;
		}

		// Token: 0x04000063 RID: 99
		private IContainer components;

		// Token: 0x04000073 RID: 115
		public Connection con;

		// Token: 0x04000074 RID: 116
		public Recordset rs;
	}
}
