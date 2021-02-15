using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public class Form4 : Form
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00012E38 File Offset: 0x00011038
		public Form4()
		{
			for (;;)
			{
				IL_CB:
				int num = Form6.sbdifomqugmuko(67);
				int num2 = 9;
				for (;;)
				{
					num2 ^= 67;
					for (;;)
					{
						IL_53:
						int num3 = 125;
						int num4 = 1;
						for (;;)
						{
							switch (num4 ^ 68)
							{
							case 66:
								switch (num3)
								{
								case 62:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.nbkvabljywxgjl(object, EventArgs)).MethodHandle;
									num3 = 3;
									goto IL_1F;
								}
								case 63:
									break;
								case 64:
									switch (num2)
									{
									case 71:
										goto IL_8D;
									case 72:
										switch (num + 68)
										{
										case 0:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = Form2.uwpnsrqhswlmjh(34);
											goto IL_11;
										case 1:
											this.nbkvabljywxgjh();
											num = -121;
											goto IL_11;
										case 2:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = -6;
											goto IL_11;
										case 3:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.nbkvabljywxgjl(object, EventArgs)).MethodHandle;
											num = -7;
											goto IL_11;
										}
										case 4:
											base.Load += this.nbkvabljywxgji;
											num = -124;
											goto IL_11;
										case 5:
											num = -123;
											goto IL_11;
										case 6:
											num = -8;
											goto IL_11;
										case 7:
											return;
										}
										goto Block_2;
									case 73:
										goto IL_CB;
									case 74:
										break;
									default:
										num3 = 2;
										goto IL_1F;
									}
									IL_11:
									num ^= 70;
									break;
								case 65:
									goto IL_8B;
								default:
									num4 = 0;
									continue;
								}
								num2 = 11;
								num3 = 124;
								goto IL_1F;
							case 67:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.get_Label8()).MethodHandle;
								num4 = 7;
								continue;
							}
							case 68:
								goto IL_53;
							case 69:
								goto IL_1F;
							}
							IL_38:
							num4 = 6;
							continue;
							IL_1F:
							num3 ^= 61;
							goto IL_38;
						}
					}
					IL_8B:
					continue;
					IL_8D:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.get_txtPassword()).MethodHandle;
					num2 = 4;
					continue;
					Block_2:
					num2 = 10;
				}
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001300C File Offset: 0x0001120C
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
						IL_ED:
						int num = 7;
						int num2 = 1;
						for (;;)
						{
							num2 ^= 80;
							for (;;)
							{
								IL_A8:
								int num3 = 1;
								int num4 = 1;
								for (;;)
								{
									switch (num4 ^ 77)
									{
									case 73:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.nbkvabljywxgjk(object, EventArgs)).MethodHandle;
										num4 = 4;
										continue;
									}
									case 74:
										switch (num3)
										{
										case 80:
											switch (num2)
											{
											case 78:
												goto IL_ED;
											case 79:
												switch (num)
												{
												case 74:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.set_Label7(Label)).MethodHandle;
													num = 1;
													goto IL_3E;
												}
												case 75:
													num = 6;
													goto IL_3E;
												case 76:
													this.components.Dispose();
													num = 0;
													goto IL_3E;
												case 77:
													goto IL_179;
												}
												goto Block_6;
											case 80:
												goto IL_120;
											case 81:
												break;
											default:
												num3 = 0;
												goto IL_4F;
											}
											IL_3E:
											num ^= 75;
											break;
										case 81:
											break;
										case 82:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.get_Label9()).MethodHandle;
											num3 = 3;
											goto IL_4F;
										}
										case 83:
											goto IL_E8;
										default:
											num4 = 6;
											continue;
										}
										num2 = 31;
										num3 = 2;
										break;
									case 75:
										goto IL_A8;
									case 76:
										break;
									default:
										IL_7A:
										num4 = 7;
										continue;
									}
									IL_4F:
									num3 ^= 81;
									goto IL_7A;
								}
							}
							IL_E8:
							continue;
							Block_6:
							num2 = 30;
							continue;
							IL_120:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.get_Label4()).MethodHandle;
							num2 = 0;
						}
					}
					IL_179:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000131C0 File Offset: 0x000113C0
		[DebuggerStepThrough]
		private void nbkvabljywxgjh()
		{
			for (;;)
			{
				int num = 34;
				for (;;)
				{
					num ^= 75;
					switch (num)
					{
					case 82:
						this.Label5 = new Label();
						this.Label4 = new Label();
						this.Label3 = new Label();
						this.Label1 = new Label();
						this.lblWelcome = new Label();
						this.GroupBox1 = new GroupBox();
						this.Label2 = new Label();
						this.OpenFileDialog1 = new OpenFileDialog();
						((ISupportInitialize)this.PictureBox1).BeginInit();
						this.GroupBox1.SuspendLayout();
						num = 18;
						continue;
					case 83:
						this.Label5.Text = "Date of Birth:";
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(118, 193);
						this.Label4.Name = "Label4";
						this.Label4.Size = new Size(80, 17);
						this.Label4.TabIndex = 128;
						this.Label4.Text = "Last Name:";
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						num = 41;
						continue;
					case 84:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.set_txtAdmNo(TextBox)).MethodHandle;
						num = 31;
						continue;
					}
					case 85:
						this.txtFirstName.Size = new Size(236, 23);
						this.txtFirstName.TabIndex = 135;
						this.txtAdmNo.Location = new Point(217, 117);
						this.txtAdmNo.Name = "txtAdmNo";
						this.txtAdmNo.Size = new Size(236, 23);
						this.txtAdmNo.TabIndex = 134;
						this.Label9.AutoSize = true;
						this.Label9.ForeColor = Color.White;
						this.Label9.Location = new Point(118, 387);
						this.Label9.Name = "Label9";
						num = 20;
						continue;
					case 86:
						this.Label2.Size = new Size(350, 31);
						this.Label2.TabIndex = 122;
						this.Label2.Text = "STUDENT PROFILE PAGE";
						this.OpenFileDialog1.FileName = "OpenFileDialog1";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(790, 519);
						base.Controls.Add(this.cmdEdit);
						base.Controls.Add(this.txtPassword);
						num = 17;
						continue;
					case 87:
						this.cmdReturn.Location = new Point(381, 470);
						this.cmdReturn.Name = "cmdReturn";
						this.cmdReturn.Size = new Size(108, 34);
						this.cmdReturn.TabIndex = 144;
						this.cmdReturn.Text = "RETURN";
						this.cmdReturn.UseVisualStyleBackColor = false;
						this.cmdUpdate.BackColor = Color.BlueViolet;
						this.cmdUpdate.ForeColor = Color.White;
						this.cmdUpdate.Location = new Point(217, 470);
						this.cmdUpdate.Name = "cmdUpdate";
						num = 42;
						continue;
					case 88:
						this.GroupBox1.Controls.Add(this.Label2);
						for (;;)
						{
							int num2 = 24;
							for (;;)
							{
								switch (num2 ^ 78)
								{
								case 77:
									num2 = 28;
									continue;
								case 78:
									this.Label2.Location = new Point(22, 19);
									num2 = 19;
									continue;
								case 79:
									this.Label2.AutoSize = true;
									num2 = 31;
									continue;
								case 80:
									this.Label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
									num2 = 22;
									continue;
								case 81:
									num2 = 30;
									continue;
								case 82:
									num = 29;
									num2 = 44;
									continue;
								case 83:
									this.GroupBox1.TabStop = false;
									num2 = 18;
									continue;
								case 84:
									num2 = 25;
									continue;
								case 85:
									this.Label2.Name = "Label2";
									num2 = 3;
									continue;
								case 86:
									num2 = 17;
									continue;
								case 87:
									this.GroupBox1.Size = new Size(397, 59);
									num2 = 46;
									continue;
								case 88:
									num2 = 0;
									continue;
								case 89:
									this.GroupBox1.TabIndex = 149;
									num2 = 20;
									continue;
								case 90:
									num2 = 29;
									continue;
								case 91:
									num2 = 47;
									continue;
								case 92:
									num2 = 1;
									continue;
								case 93:
									num2 = 27;
									continue;
								case 94:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.set_DateTimePicker1(DateTimePicker)).MethodHandle;
									num2 = 16;
									continue;
								}
								case 95:
									this.GroupBox1.Location = new Point(216, 14);
									num2 = 21;
									continue;
								case 96:
									num2 = 23;
									continue;
								case 97:
									this.GroupBox1.Name = "GroupBox1";
									num2 = 26;
									continue;
								case 98:
									goto IL_58D;
								}
								break;
							}
						}
						IL_58D:
						continue;
					case 89:
						base.SuspendLayout();
						this.cmdEdit.BackColor = Color.BlueViolet;
						this.cmdEdit.ForeColor = Color.White;
						this.cmdEdit.Location = new Point(62, 470);
						this.cmdEdit.Name = "cmdEdit";
						this.cmdEdit.Size = new Size(116, 34);
						this.cmdEdit.TabIndex = 148;
						this.cmdEdit.Text = "EDIT INFO";
						this.cmdEdit.UseVisualStyleBackColor = false;
						this.txtPassword.Location = new Point(217, 422);
						num = 45;
						continue;
					case 90:
						base.Controls.Add(this.lblPassword);
						for (;;)
						{
							int num3 = Form12.wsyoqrrjsoniul(53);
							for (;;)
							{
								num3 ^= 76;
								switch (num3 + 76)
								{
								case 0:
									num3 = -6;
									continue;
								case 1:
									num3 = -5;
									continue;
								case 2:
									base.Controls.Add(this.txtEmail);
									num3 = -124;
									continue;
								case 3:
									base.Controls.Add(this.PictureBox1);
									num3 = -15;
									continue;
								case 4:
									base.Controls.Add(this.rbFemale);
									num3 = -120;
									continue;
								case 5:
									base.Controls.Add(this.rbMale);
									num3 = -7;
									continue;
								case 6:
									base.Controls.Add(this.cmdRegister);
									num3 = -117;
									continue;
								case 7:
									base.Controls.Add(this.cmdUpdate);
									num3 = -13;
									continue;
								case 8:
									num = 43;
									num3 = Form10.pdqangwdsoatqb(66);
									continue;
								case 9:
									num3 = -115;
									continue;
								case 10:
									num3 = -10;
									continue;
								case 11:
									num3 = -12;
									continue;
								case 12:
									base.Controls.Add(this.cmdReturn);
									num3 = -119;
									continue;
								case 13:
									base.Controls.Add(this.cboProgram);
									num3 = -113;
									continue;
								case 14:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.set_lblPassword(Label)).MethodHandle;
									num3 = -114;
									continue;
								}
								case 15:
									num3 = -118;
									continue;
								case 16:
									num3 = -11;
									continue;
								case 17:
									num3 = -9;
									continue;
								case 18:
									base.Controls.Add(this.DateTimePicker1);
									num3 = -8;
									continue;
								case 19:
									num3 = -116;
									continue;
								case 20:
									num3 = -16;
									continue;
								case 21:
									goto IL_821;
								}
								break;
							}
						}
						IL_821:
						continue;
					case 91:
						this.cmdRegister.BackColor = Color.BlueViolet;
						this.cmdRegister.ForeColor = Color.White;
						this.cmdRegister.Location = new Point(524, 470);
						this.cmdRegister.Name = "cmdRegister";
						this.cmdRegister.Size = new Size(205, 34);
						this.cmdRegister.TabIndex = 145;
						this.cmdRegister.Text = "SEMESTER REGISTRATION";
						this.cmdRegister.UseVisualStyleBackColor = false;
						this.cmdReturn.BackColor = Color.BlueViolet;
						this.cmdReturn.ForeColor = Color.White;
						num = 28;
						continue;
					case 92:
						this.rbFemale.Text = "Female";
						this.rbFemale.UseVisualStyleBackColor = true;
						this.rbMale.AutoSize = true;
						this.rbMale.ForeColor = Color.White;
						this.rbMale.Location = new Point(217, 263);
						this.rbMale.Name = "rbMale";
						this.rbMale.Size = new Size(56, 21);
						this.rbMale.TabIndex = 142;
						this.rbMale.Text = "Male";
						this.rbMale.UseVisualStyleBackColor = true;
						num = 33;
						continue;
					case 93:
						this.DateTimePicker1 = new DateTimePicker();
						this.txtEmail = new TextBox();
						this.txtPhone = new TextBox();
						this.txtLastName = new TextBox();
						this.txtFirstName = new TextBox();
						this.txtAdmNo = new TextBox();
						this.Label9 = new Label();
						this.Label8 = new Label();
						this.Label7 = new Label();
						this.Label6 = new Label();
						num = 25;
						continue;
					case 94:
						this.cboProgram.TabIndex = 140;
						for (;;)
						{
							int num4 = 6;
							for (;;)
							{
								switch (num4 ^ 82)
								{
								case 76:
									num4 = 31;
									continue;
								case 77:
									this.txtEmail.Location = new Point(217, 384);
									num4 = 12;
									continue;
								case 78:
									num4 = 1;
									continue;
								case 79:
									this.DateTimePicker1.Size = new Size(236, 23);
									num4 = 4;
									continue;
								case 80:
									this.DateTimePicker1.Location = new Point(217, 231);
									num4 = 5;
									continue;
								case 81:
									num4 = 8;
									continue;
								case 82:
									num4 = 7;
									continue;
								case 83:
									this.txtEmail.Size = new Size(236, 23);
									num4 = 11;
									continue;
								case 84:
									num4 = 2;
									continue;
								case 85:
									num = 40;
									num4 = 51;
									continue;
								case 86:
									num4 = 14;
									continue;
								case 87:
									num4 = 15;
									continue;
								case 88:
									this.txtEmail.Name = "txtEmail";
									num4 = 28;
									continue;
								case 89:
									num4 = 50;
									continue;
								case 90:
									this.DateTimePicker1.Value = new DateTime(2017, 4, 8, 0, 0, 0, 0);
									num4 = 30;
									continue;
								case 91:
									num4 = 29;
									continue;
								case 92:
									this.DateTimePicker1.TabIndex = 139;
									num4 = 3;
									continue;
								case 93:
									this.DateTimePicker1.Name = "DateTimePicker1";
									num4 = 9;
									continue;
								case 94:
									num4 = 10;
									continue;
								case 95:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.get_Label3()).MethodHandle;
									num4 = 13;
									continue;
								}
								case 96:
									this.txtEmail.TabIndex = 138;
									num4 = 0;
									continue;
								case 97:
									goto IL_C02;
								}
								break;
							}
						}
						IL_C02:
						continue;
					case 95:
						this.Label9.Size = new Size(46, 17);
						this.Label9.TabIndex = 133;
						this.Label9.Text = "Email:";
						this.Label8.AutoSize = true;
						this.Label8.ForeColor = Color.White;
						this.Label8.Location = new Point(118, 345);
						this.Label8.Name = "Label8";
						this.Label8.Size = new Size(75, 17);
						this.Label8.TabIndex = 132;
						this.Label8.Text = "Phone No:";
						num = 35;
						continue;
					case 96:
						base.Controls.Add(this.txtPhone);
						base.Controls.Add(this.txtLastName);
						base.Controls.Add(this.txtFirstName);
						base.Controls.Add(this.txtAdmNo);
						base.Controls.Add(this.Label9);
						base.Controls.Add(this.Label8);
						base.Controls.Add(this.Label7);
						base.Controls.Add(this.Label6);
						base.Controls.Add(this.Label5);
						base.Controls.Add(this.Label4);
						num = 44;
						continue;
					case 97:
						this.cmdUpdate.Size = new Size(116, 34);
						this.cmdUpdate.TabIndex = 124;
						this.cmdUpdate.Text = "SAVE";
						this.cmdUpdate.UseVisualStyleBackColor = false;
						this.rbFemale.AutoSize = true;
						this.rbFemale.ForeColor = Color.White;
						this.rbFemale.Location = new Point(381, 263);
						this.rbFemale.Name = "rbFemale";
						this.rbFemale.Size = new Size(72, 21);
						this.rbFemale.TabIndex = 143;
						num = 23;
						continue;
					case 98:
						this.Label3.Location = new Point(118, 155);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(80, 17);
						this.Label3.TabIndex = 127;
						this.Label3.Text = "First Name:";
						this.Label1.AutoSize = true;
						this.Label1.ForeColor = Color.White;
						this.Label1.Location = new Point(118, 117);
						this.Label1.Name = "Label1";
						this.Label1.Size = new Size(62, 17);
						num = 47;
						continue;
					case 99:
						this.txtPhone.Location = new Point(217, 342);
						this.txtPhone.Name = "txtPhone";
						this.txtPhone.Size = new Size(236, 23);
						this.txtPhone.TabIndex = 137;
						this.txtLastName.Location = new Point(217, 193);
						this.txtLastName.Name = "txtLastName";
						this.txtLastName.Size = new Size(236, 23);
						this.txtLastName.TabIndex = 136;
						this.txtFirstName.Location = new Point(217, 155);
						this.txtFirstName.Name = "txtFirstName";
						num = 30;
						continue;
					case 100:
						this.Label1.TabIndex = 126;
						this.Label1.Text = "Adm No:";
						this.lblWelcome.AutoSize = true;
						this.lblWelcome.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.lblWelcome.ForeColor = Color.White;
						this.lblWelcome.Location = new Point(269, 85);
						this.lblWelcome.Name = "lblWelcome";
						this.lblWelcome.Size = new Size(74, 26);
						this.lblWelcome.TabIndex = 125;
						this.lblWelcome.Text = "Profile";
						num = 19;
						continue;
					case 101:
						this.Label6.Name = "Label6";
						this.Label6.Size = new Size(60, 17);
						this.Label6.TabIndex = 130;
						this.Label6.Text = "Gender:";
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(118, 231);
						this.Label5.Name = "Label5";
						this.Label5.Size = new Size(91, 17);
						this.Label5.TabIndex = 129;
						num = 24;
						continue;
					case 102:
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.Size = new Size(236, 23);
						this.txtPassword.TabIndex = 147;
						this.lblPassword.AutoSize = true;
						this.lblPassword.ForeColor = Color.White;
						this.lblPassword.Location = new Point(118, 425);
						this.lblPassword.Name = "lblPassword";
						this.lblPassword.Size = new Size(73, 17);
						this.lblPassword.TabIndex = 146;
						this.lblPassword.Text = "Password:";
						num = 16;
						continue;
					case 103:
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.Label1);
						base.Controls.Add(this.lblWelcome);
						base.Controls.Add(this.GroupBox1);
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form4";
						this.Text = "Form4";
						((ISupportInitialize)this.PictureBox1).EndInit();
						this.GroupBox1.ResumeLayout(false);
						num = 32;
						continue;
					case 104:
						this.Label7.AutoSize = true;
						this.Label7.ForeColor = Color.White;
						this.Label7.Location = new Point(118, 300);
						this.Label7.Name = "Label7";
						this.Label7.Size = new Size(66, 17);
						this.Label7.TabIndex = 131;
						this.Label7.Text = "Program:";
						this.Label6.AutoSize = true;
						this.Label6.ForeColor = Color.White;
						this.Label6.Location = new Point(118, 263);
						num = 46;
						continue;
					case 105:
						this.cmdEdit = new Button();
						this.txtPassword = new TextBox();
						this.lblPassword = new Label();
						this.cmdRegister = new Button();
						this.cmdReturn = new Button();
						this.cmdUpdate = new Button();
						this.rbFemale = new RadioButton();
						this.rbMale = new RadioButton();
						this.PictureBox1 = new PictureBox();
						this.cboProgram = new ComboBox();
						num = 22;
						continue;
					case 106:
						this.PictureBox1.BackColor = Color.SteelBlue;
						this.PictureBox1.Location = new Point(524, 117);
						this.PictureBox1.Name = "PictureBox1";
						this.PictureBox1.Size = new Size(200, 150);
						this.PictureBox1.TabIndex = 141;
						this.PictureBox1.TabStop = false;
						this.cboProgram.FormattingEnabled = true;
						this.cboProgram.Location = new Point(217, 300);
						this.cboProgram.Name = "cboProgram";
						this.cboProgram.Size = new Size(236, 24);
						num = 21;
						continue;
					case 107:
						goto IL_14C4;
					}
					break;
				}
			}
			IL_14C4:
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00014738 File Offset: 0x00012938
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00014748 File Offset: 0x00012948
		internal virtual Button cmdEdit
		{
			[CompilerGenerated]
			get
			{
				return this._cmdEdit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nbkvabljywxgjm);
				Button cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click -= value2;
				}
				this._cmdEdit = value;
				cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click += value2;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000147B3 File Offset: 0x000129B3
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000147C1 File Offset: 0x000129C1
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000147CE File Offset: 0x000129CE
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000147DC File Offset: 0x000129DC
		internal virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000147E9 File Offset: 0x000129E9
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000147F8 File Offset: 0x000129F8
		internal virtual Button cmdRegister
		{
			[CompilerGenerated]
			get
			{
				return this._cmdRegister;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nbkvabljywxgjl);
				Button cmdRegister = this._cmdRegister;
				if (cmdRegister != null)
				{
					cmdRegister.Click -= value2;
				}
				this._cmdRegister = value;
				cmdRegister = this._cmdRegister;
				if (cmdRegister != null)
				{
					cmdRegister.Click += value2;
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00014863 File Offset: 0x00012A63
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00014874 File Offset: 0x00012A74
		internal virtual Button cmdReturn
		{
			[CompilerGenerated]
			get
			{
				return this._cmdReturn;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nbkvabljywxgjk);
				Button cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click -= value2;
				}
				this._cmdReturn = value;
				cmdReturn = this._cmdReturn;
				if (cmdReturn != null)
				{
					cmdReturn.Click += value2;
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000148DF File Offset: 0x00012ADF
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000148F0 File Offset: 0x00012AF0
		internal virtual Button cmdUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._cmdUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nbkvabljywxgjj);
				Button cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click -= value2;
				}
				this._cmdUpdate = value;
				cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click += value2;
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001495B File Offset: 0x00012B5B
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00014969 File Offset: 0x00012B69
		internal virtual RadioButton rbFemale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00014976 File Offset: 0x00012B76
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00014984 File Offset: 0x00012B84
		internal virtual RadioButton rbMale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00014991 File Offset: 0x00012B91
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0001499F File Offset: 0x00012B9F
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000149AC File Offset: 0x00012BAC
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000149BA File Offset: 0x00012BBA
		internal virtual ComboBox cboProgram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000149C7 File Offset: 0x00012BC7
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000149D5 File Offset: 0x00012BD5
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000149E2 File Offset: 0x00012BE2
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000149F0 File Offset: 0x00012BF0
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000149FD File Offset: 0x00012BFD
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00014A0B File Offset: 0x00012C0B
		internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00014A18 File Offset: 0x00012C18
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00014A26 File Offset: 0x00012C26
		internal virtual TextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00014A33 File Offset: 0x00012C33
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00014A41 File Offset: 0x00012C41
		internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00014A4E File Offset: 0x00012C4E
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00014A5C File Offset: 0x00012C5C
		internal virtual TextBox txtAdmNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00014A69 File Offset: 0x00012C69
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00014A77 File Offset: 0x00012C77
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00014A84 File Offset: 0x00012C84
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00014A92 File Offset: 0x00012C92
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00014A9F File Offset: 0x00012C9F
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00014AAD File Offset: 0x00012CAD
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00014ABA File Offset: 0x00012CBA
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00014AC8 File Offset: 0x00012CC8
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00014AD5 File Offset: 0x00012CD5
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00014AE3 File Offset: 0x00012CE3
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00014AF0 File Offset: 0x00012CF0
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00014AFE File Offset: 0x00012CFE
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00014B0B File Offset: 0x00012D0B
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00014B19 File Offset: 0x00012D19
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00014B26 File Offset: 0x00012D26
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00014B34 File Offset: 0x00012D34
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00014B41 File Offset: 0x00012D41
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00014B4F File Offset: 0x00012D4F
		internal virtual Label lblWelcome { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00014B5C File Offset: 0x00012D5C
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00014B6A File Offset: 0x00012D6A
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00014B77 File Offset: 0x00012D77
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00014B85 File Offset: 0x00012D85
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00014B92 File Offset: 0x00012D92
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00014BA0 File Offset: 0x00012DA0
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600016F RID: 367 RVA: 0x00014BB0 File Offset: 0x00012DB0
		private void nbkvabljywxgji(object by, EventArgs bz)
		{
			for (;;)
			{
				IL_F6:
				int num = 3;
				int num2 = -20;
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						IL_63:
						int num3 = 10;
						int num4 = -11;
						for (;;)
						{
							num4 ^= 88;
							switch (num4 + 86)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.Dispose(bool)).MethodHandle;
								num4 = -14;
								continue;
							}
							case 1:
								switch (num3)
								{
								case 81:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.get_OpenFileDialog1()).MethodHandle;
									num3 = 8;
									goto IL_19;
								}
								case 82:
									break;
								case 83:
									switch (num2 + 83)
									{
									case 0:
										switch (num)
										{
										case 81:
											num = 10;
											goto IL_0B;
										case 82:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = 7;
											goto IL_0B;
										case 83:
											this.rs.Open("Select * from StudentsProfile where AdmNo = '" + yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxh.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 4;
											goto IL_0B;
										case 84:
										{
											string str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
											num = 8;
											goto IL_0B;
										}
										case 85:
											num = 5;
											goto IL_0B;
										case 86:
											num = 2;
											goto IL_0B;
										case 87:
											num = 9;
											goto IL_0B;
										case 88:
											this.display();
											num = 0;
											goto IL_0B;
										case 89:
										{
											string str;
											this.lblWelcome.Text = str + "'s " + this.lblWelcome.Text;
											num = 6;
											goto IL_0B;
										}
										case 90:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.set_OpenFileDialog1(OpenFileDialog)).MethodHandle;
											num = 11;
											goto IL_0B;
										}
										case 91:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_E8;
									case 2:
										goto IL_F6;
									case 3:
										break;
									default:
										num3 = 11;
										goto IL_19;
									}
									IL_0B:
									num ^= 81;
									break;
								case 84:
									goto IL_A6;
								default:
									num4 = Form12.wsyoqrrjsoniul(58);
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(23);
								num3 = 13;
								goto IL_19;
							case 2:
								goto IL_63;
							case 3:
								goto IL_19;
							}
							IL_34:
							num4 = Form7.mqgfoefwabbyeu(21);
							continue;
							IL_19:
							num3 ^= 89;
							goto IL_34;
						}
					}
					IL_A6:
					continue;
					Block_2:
					num2 = -13;
					continue;
					IL_E8:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.get_Label5()).MethodHandle;
					num2 = -14;
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00014DF8 File Offset: 0x00012FF8
		public void display()
		{
			for (;;)
			{
				IL_A7:
				int num = 25;
				int num2 = Form6.sbdifomqugmuko(57);
				for (;;)
				{
					num2 ^= 88;
					for (;;)
					{
						int num3 = 14;
						for (;;)
						{
							switch (num3 ^ 84)
							{
							case 89:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.get_rbMale()).MethodHandle;
								num3 = 13;
								continue;
							}
							case 90:
								switch (num2 + 80)
								{
								case 0:
									switch (num)
									{
									case 83:
										this.txtLastName.Text = Conversions.ToString(this.rs.Fields["LastName"].Value);
										num = 21;
										goto IL_0B;
									case 84:
										num = 24;
										goto IL_0B;
									case 85:
										num = 20;
										goto IL_0B;
									case 86:
										this.txtAdmNo.Text = Conversions.ToString(this.rs.Fields["AdmNo"].Value);
										num = 27;
										goto IL_0B;
									case 87:
										this.txtFirstName.Text = Conversions.ToString(this.rs.Fields["FirstName"].Value);
										num = 22;
										goto IL_0B;
									case 88:
										this.DateTimePicker1.Value = Conversions.ToDate(this.rs.Fields["DOB"].Value);
										num = 26;
										goto IL_0B;
									case 89:
										num = 28;
										goto IL_0B;
									case 90:
										num = 23;
										goto IL_0B;
									case 91:
									{
										bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbMale.Text, false);
										num = 19;
										goto IL_0B;
									}
									case 92:
									{
										bool flag;
										if (flag)
										{
											num = 17;
											goto IL_0B;
										}
										goto IL_208;
									}
									case 93:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.get_Label4()).MethodHandle;
										num = 18;
										goto IL_0B;
									}
									case 94:
										goto IL_205;
									}
									goto Block_1;
								case 1:
									goto IL_A7;
								case 2:
									goto IL_B8;
								case 3:
									break;
								default:
									num3 = 15;
									continue;
								}
								IL_0B:
								num ^= 79;
								goto IL_55;
							case 91:
								goto IL_55;
							case 92:
								goto IL_63;
							}
							break;
							IL_55:
							num2 = Form12.wsyoqrrjsoniul(41);
							num3 = 8;
						}
					}
					IL_63:
					continue;
					Block_1:
					num2 = -23;
					continue;
					IL_B8:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.get_Label5()).MethodHandle;
					num2 = -22;
				}
			}
			IL_205:
			bool flag2 = false;
			goto IL_20B;
			IL_208:
			flag2 = true;
			IL_20B:
			if (!flag2)
			{
				this.rbMale.Checked = true;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbFemale.Text, false);
				if (flag3)
				{
					this.rbFemale.Checked = true;
				}
			}
			this.cboProgram.Text = Conversions.ToString(this.rs.Fields["Program"].Value);
			for (;;)
			{
				int num4 = Form6.sbdifomqugmuko(64);
				for (;;)
				{
					num4 ^= 88;
					switch (num4 + 81)
					{
					case 0:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.set_cmdEdit(Button)).MethodHandle;
						num4 = -9;
						continue;
					}
					case 1:
						num4 = -30;
						continue;
					case 2:
						num4 = -32;
						continue;
					case 3:
						num4 = -27;
						continue;
					case 4:
						this.txtPhone.Text = Conversions.ToString(this.rs.Fields["PhoneNo"].Value);
						num4 = -18;
						continue;
					case 5:
						num4 = -21;
						continue;
					case 6:
						this.txtEmail.Text = Conversions.ToString(this.rs.Fields["Email"].Value);
						num4 = -24;
						continue;
					case 7:
						num4 = -19;
						continue;
					case 8:
						num4 = Form12.wsyoqrrjsoniul(54);
						continue;
					case 9:
						this.txtPassword.Text = Conversions.ToString(this.rs.Fields["Password"].Value);
						num4 = -17;
						continue;
					case 10:
						num4 = -29;
						continue;
					case 11:
						this.PictureBox1.Image = Image.FromFile(Conversions.ToString(this.rs.Fields["Photo"].Value));
						num4 = -23;
						continue;
					case 12:
						this.txtPassword.Visible = false;
						num4 = -22;
						continue;
					case 13:
						this.lblPassword.Visible = false;
						num4 = -31;
						continue;
					case 14:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001526C File Offset: 0x0001346C
		private void nbkvabljywxgjj(object ca, EventArgs cb)
		{
			for (;;)
			{
				IL_29:
				int num = Form12.wsyoqrrjsoniul(51);
				int num2 = 12;
				for (;;)
				{
					switch (num2 ^ 80)
					{
					case 89:
						goto IL_29;
					case 90:
						switch (num + 84)
						{
						case 0:
							num = -27;
							goto IL_08;
						case 1:
							this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
							num = -25;
							goto IL_08;
						case 2:
							this.rs.Fields["AdmNo"].Value = this.txtAdmNo.Text;
							num = -26;
							goto IL_08;
						case 3:
						{
							bool @checked;
							if (@checked)
							{
								num = -32;
								goto IL_08;
							}
							goto IL_16A;
						}
						case 4:
							num = -29;
							goto IL_08;
						case 5:
							num = -6;
							goto IL_08;
						case 6:
						{
							bool @checked = this.rbMale.Checked;
							num = -8;
							goto IL_08;
						}
						case 7:
						{
							RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.set_txtEmail(TextBox)).MethodHandle;
							num = -28;
							goto IL_08;
						}
						case 8:
							this.rs.Fields["LastName"].Value = this.txtLastName.Text;
							num = -30;
							goto IL_08;
						case 9:
							num = -31;
							goto IL_08;
						case 10:
							this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
							num = Form2.uwpnsrqhswlmjh(34);
							goto IL_08;
						case 11:
							goto IL_167;
						default:
							num2 = 9;
							continue;
						}
						break;
					case 91:
					{
						RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.nbkvabljywxgjh()).MethodHandle;
						num2 = 11;
						continue;
					}
					case 92:
						goto IL_08;
					}
					IL_23:
					num2 = 10;
					continue;
					IL_08:
					num ^= 87;
					goto IL_23;
				}
			}
			IL_167:
			bool flag = false;
			goto IL_16D;
			IL_16A:
			flag = true;
			IL_16D:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num3 = Form2.uwpnsrqhswlmjh(45);
					for (;;)
					{
						num3 ^= 88;
						switch (num3 + 80)
						{
						case 0:
						{
							RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.get_cmdUpdate()).MethodHandle;
							num3 = -24;
							continue;
						}
						case 1:
							num3 = -22;
							continue;
						case 2:
							num3 = -21;
							continue;
						case 3:
							goto IL_1DF;
						}
						break;
					}
				}
				IL_1DF:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["Program"].Value = this.cboProgram.Text;
			for (;;)
			{
				int num4 = 11;
				for (;;)
				{
					switch (num4 ^ 85)
					{
					case 87:
						num4 = 15;
						continue;
					case 88:
						num4 = 12;
						continue;
					case 89:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num4 = 2;
						continue;
					case 90:
						Interaction.MsgBox("Record Updated Successfully.", MsgBoxStyle.Information, null);
						num4 = 52;
						continue;
					case 91:
						num4 = 10;
						continue;
					case 92:
						num4 = 55;
						continue;
					case 93:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num4 = 14;
						continue;
					case 94:
						num4 = 8;
						continue;
					case 95:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num4 = 13;
						continue;
					case 96:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.set_cmdEdit(Button)).MethodHandle;
						num4 = 53;
						continue;
					}
					case 97:
						this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
						num4 = 9;
						continue;
					case 98:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00015660 File Offset: 0x00013860
		private void nbkvabljywxgjk(object cc, EventArgs cd)
		{
			for (;;)
			{
				IL_FE:
				int num = 51;
				int num2 = 15;
				for (;;)
				{
					num2 ^= 84;
					for (;;)
					{
						IL_47:
						int num3 = Form7.mqgfoefwabbyeu(31);
						int num4 = 4;
						for (;;)
						{
							switch (num4 ^ 81)
							{
							case 82:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.set_GroupBox1(GroupBox)).MethodHandle;
								num4 = 3;
								continue;
							}
							case 83:
								goto IL_47;
							case 84:
								switch (num3 + 91)
								{
								case 0:
									switch (num2)
									{
									case 88:
										switch (num)
										{
										case 91:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxh.txtPassword.Text = "";
											num = 48;
											goto IL_0B;
										case 92:
											base.Hide();
											num = 49;
											goto IL_0B;
										case 93:
											num = 10;
											goto IL_0B;
										case 94:
											num = 53;
											goto IL_0B;
										case 95:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.get_cboProgram()).MethodHandle;
											num = 14;
											goto IL_0B;
										}
										case 96:
											num = 50;
											goto IL_0B;
										case 97:
											num = 13;
											goto IL_0B;
										case 98:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxh.txtUsername.Text = "";
											num = 12;
											goto IL_0B;
										case 99:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelwz.Show();
											num = 15;
											goto IL_0B;
										case 100:
											return;
										}
										goto Block_3;
									case 89:
										goto IL_F0;
									case 90:
										goto IL_FE;
									case 91:
										break;
									default:
										num3 = -2;
										goto IL_1C;
									}
									IL_0B:
									num ^= 81;
									break;
								case 1:
									break;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.nbkvabljywxgjk(object, EventArgs)).MethodHandle;
									num3 = Form7.mqgfoefwabbyeu(25);
									goto IL_1C;
								}
								case 3:
									goto IL_B2;
								default:
									num4 = 2;
									continue;
								}
								num2 = 12;
								num3 = -16;
								goto IL_1C;
							case 85:
								goto IL_1C;
							}
							IL_35:
							num4 = 5;
							continue;
							IL_1C:
							num3 ^= 88;
							goto IL_35;
						}
					}
					IL_B2:
					continue;
					Block_3:
					num2 = 14;
					continue;
					IL_F0:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.get_Label3()).MethodHandle;
					num2 = 13;
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00015848 File Offset: 0x00013A48
		private void nbkvabljywxgjl(object ce, EventArgs cf)
		{
			for (;;)
			{
				IL_A0:
				int num = 21;
				int num2 = 0;
				for (;;)
				{
					num2 ^= 85;
					for (;;)
					{
						IL_37:
						int num3 = Form12.wsyoqrrjsoniul(58);
						int num4 = 14;
						for (;;)
						{
							switch (num4 ^ 80)
							{
							case 91:
								goto IL_37;
							case 92:
								switch (num3 + 90)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.set_cmdRegister(Button)).MethodHandle;
									num3 = -6;
									goto IL_19;
								}
								case 1:
									break;
								case 2:
									switch (num2)
									{
									case 82:
										goto IL_A0;
									case 83:
										goto IL_AA;
									case 84:
										switch (num)
										{
										case 86:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.get_Label9()).MethodHandle;
											num = 25;
											goto IL_0B;
										}
										case 87:
											num = 23;
											goto IL_0B;
										case 88:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxb.Show();
											num = 22;
											goto IL_0B;
										case 89:
											num = 20;
											goto IL_0B;
										case 90:
											base.Hide();
											num = 24;
											goto IL_0B;
										case 91:
											return;
										}
										goto Block_2;
									case 85:
										break;
									default:
										num3 = -5;
										goto IL_19;
									}
									IL_0B:
									num ^= 79;
									break;
								case 3:
									goto IL_9B;
								default:
									num4 = 11;
									continue;
								}
								num2 = 1;
								num3 = Form7.mqgfoefwabbyeu(27);
								goto IL_19;
							case 93:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.get_cmdUpdate()).MethodHandle;
								num4 = 13;
								continue;
							}
							case 94:
								goto IL_19;
							}
							IL_32:
							num4 = 12;
							continue;
							IL_19:
							num3 ^= 92;
							goto IL_32;
						}
					}
					IL_9B:
					continue;
					IL_AA:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.set_txtPhone(TextBox)).MethodHandle;
					num2 = 6;
					continue;
					Block_2:
					num2 = 7;
				}
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000159C8 File Offset: 0x00013BC8
		private void nbkvabljywxgjm(object cg, EventArgs ch)
		{
			for (;;)
			{
				IL_BB:
				int num = Form7.mqgfoefwabbyeu(29);
				int num2 = 7;
				for (;;)
				{
					num2 ^= 89;
					for (;;)
					{
						IL_47:
						int num3 = Form2.uwpnsrqhswlmjh(42);
						int num4 = 7;
						for (;;)
						{
							switch (num4 ^ 92)
							{
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form4.get_Label4()).MethodHandle;
								num4 = 4;
								continue;
							}
							case 89:
								goto IL_47;
							case 90:
								switch (num3 + 91)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form4.get_Label2()).MethodHandle;
									num3 = -2;
									goto IL_1C;
								}
								case 1:
									break;
								case 2:
									switch (num2)
									{
									case 91:
										goto IL_AE;
									case 92:
										goto IL_BB;
									case 93:
										switch (num + 91)
										{
										case 0:
											this.lblPassword.Visible = true;
											num = -12;
											goto IL_0B;
										case 1:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form4.set_Label5(Label)).MethodHandle;
											num = -11;
											goto IL_0B;
										}
										case 2:
											num = -6;
											goto IL_0B;
										case 3:
											num = Form12.wsyoqrrjsoniul(51);
											goto IL_0B;
										case 4:
											this.txtPassword.Visible = true;
											num = -5;
											goto IL_0B;
										case 5:
											return;
										}
										goto Block_3;
									case 94:
										break;
									default:
										num3 = -3;
										goto IL_1C;
									}
									IL_0B:
									num ^= 83;
									break;
								case 3:
									goto IL_A9;
								default:
									num4 = 5;
									continue;
								}
								num2 = 4;
								num3 = -13;
								goto IL_1C;
							case 91:
								goto IL_1C;
							}
							IL_35:
							num4 = 6;
							continue;
							IL_1C:
							num3 ^= 91;
							goto IL_35;
						}
					}
					IL_A9:
					continue;
					IL_AE:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form4.set_Label4(Label)).MethodHandle;
					num2 = 2;
					continue;
					Block_3:
					num2 = 5;
				}
			}
		}

		// Token: 0x04000088 RID: 136
		private IContainer components;

		// Token: 0x040000A5 RID: 165
		public Connection con;

		// Token: 0x040000A6 RID: 166
		public Recordset rs;

		// Token: 0x040000A7 RID: 167
		public string str;
	}
}
